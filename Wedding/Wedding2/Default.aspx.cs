﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

using WeddingData;

public partial class _Default : System.Web.UI.Page
{
	protected Guest guest;
	protected Guid guestID;

	protected void Page_Load( object sender, EventArgs e )
	{
		if( !Page.IsPostBack )
		{
		}
		else
		{
			if( Session[ "GuestID" ] != null )
			{
				if( !Guid.TryParse(Session[ "GuestID" ].ToString(), out guestID ) )
				{
					Debug.Fail("Invalid guid");
				}
				Debug.Assert( guestID != Guid.Empty );
			}

			if( guestID != Guid.Empty && guest == null )
			{
				using( WeddingContext db = WeddingContext.New() )
				{
					Debug.Assert( db.DatabaseExists() );
					Debug.Assert( guestID != Guid.Empty );

					// Find person from db
					var query = from b in db.Guest
								where b.GuestID == guestID
								select b;

					guest = query.SingleOrDefault();
				}
			}

			if( guest != null )
			{
				HydrateCountList();
			}
		}
	}



	protected void ButtonLookup_Click( object sender, EventArgs e )
	{
		using( WeddingContext db = WeddingContext.New() )
		{
			Debug.Assert( db.DatabaseExists() );

			// Find person from db
			var query = from b in db.Guest
						where b.GuestName == this.TextBoxPartyName.Text
						&& b.ZipCode == this.TextBoxZipCode.Text
						select b;

			guest = query.FirstOrDefault();

			if( guest != null )
			{
				this.DivRsvpFindGuest.Visible = false;
				this.DivRsvpDetails.Visible = true;

				Session[ "GuestID" ] = guest.GuestID.ToString();

				if( guest._RsvpDate.HasValue )
				{
					// Guest has already RSVP'd, this is an update
					HydrateCountList();
					this.RadioCount.SelectedIndex = guest._Count.Value;
					this.RadioAccommodations.SelectedIndex = guest._NeedAccommodations.Value;
					this.TextBoxNotes.Text = guest._Notes;
				}
			}
			else
			{
				this.DivWarning.Visible = true;
				this.LabelWarning.Text = "I can't seem to find you!  Please try again or email Dave or Ellen.";
			}
		}
	}

	protected void ButtonSave_Click( object sender, EventArgs e )
	{
		using( WeddingContext db = WeddingContext.New() )
		{
			Debug.Assert( db.DatabaseExists() );
			Debug.Assert( guestID != Guid.Empty );

			var query = from b in db.Guest
						where b.GuestID == guestID
						select b;

			Guest guest1 = query.Single();
			guest1._Count = Byte.Parse( this.RadioCount.SelectedValue );
			guest1._NeedAccommodations = Byte.Parse( this.RadioAccommodations.SelectedValue );
			guest1._Notes = this.TextBoxNotes.Text;
			guest1._RsvpDate = DateTime.Now;
			db.SubmitChanges();
		}

		this.LabelSavedMessage.Text = "Thank for you RSVP!";
	}

	private void HydrateCountList()
	{
		if( this.RadioCount.Items.Count == 0 )
		{
			for( Byte k = 0; k <= guest.MaxSize; k++ )
			{
				String text = k == 0 ? "0 (not attending)" : k.ToString();
				ListItem li = new ListItem(text, k.ToString());
				this.RadioCount.Items.Add( li );
			}
		}
	}
}