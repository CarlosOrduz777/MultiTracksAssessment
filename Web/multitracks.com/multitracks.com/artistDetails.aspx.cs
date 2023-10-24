using DataAccess;
using MTDataAccess;
using System;
using System.Data;

public partial class ArtistDetails:MultitracksPage
{
    DataTable DtSongs;
    DataTable DtAlbums;
    public DataTable DtArtist;
    protected void Page_Load(object sender, EventArgs e)
    {
        var sql = new SqlWebForm();
        var artistIdQueryString = Request.QueryString["ArtistId"];
        if (artistIdQueryString == null)
        {
            Response.Redirect("default.aspx");
            return;
        }
        try
        {
            sql.Parameters.Add(new System.Data.SqlClient.SqlParameter("@artistId", artistIdQueryString));
            var result = sql.ExecuteStoredProcedureDS("GetArtistDetails", true);
            DtSongs = result.Tables[0];
            DtAlbums = result.Tables[1];
            DtArtist = result.Tables[2];

            repeatSongs.DataSource = DtSongs;
            repeatSongs.DataBind();

            repeatAlbums.DataSource = DtAlbums;
            repeatAlbums.DataBind();

            textBiography.Text = DtArtist.Rows[0]["biography"].ToString();
            imageArtistHero.ImageUrl = DtArtist.Rows[0]["heroURL"].ToString();
            imageArtistHero.DescriptionUrl = DtArtist.Rows[0]["heroURL"].ToString();
            imageArtistHero.AlternateText = DtArtist.Rows[0]["title"].ToString();

            imageArtistProfile.ImageUrl = DtArtist.Rows[0]["imageURL"].ToString();
            imageArtistProfile.DescriptionUrl = DtArtist.Rows[0]["imageURL"].ToString();
            imageArtistProfile.AlternateText = DtArtist.Rows[0]["title"].ToString();
        }
        catch (Exception)
        {

            Response.Redirect("default.aspx");
        }
    }
}