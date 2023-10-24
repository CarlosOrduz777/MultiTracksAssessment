using DataAccess;
using MTDataAccess;
using System;

public partial class Default : MultitracksPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var sql = new SqlWebForm();

        try
        {
            
            //sql.Parameters.Add("@stepID", 1);
            var data = sql.ExecuteStoredProcedureDT("GetAssessmentSteps");
            Console.WriteLine(data);
            assessmentItems.DataSource = data;
            assessmentItems.DataBind();

            publishDB.Visible = true;
            items.Visible = true;
        }
        catch(Exception ex) 
        {
            Console.WriteLine(ex.Message);
            publishDB.Visible = true;
            items.Visible = true;
        }
    }
}
