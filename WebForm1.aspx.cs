using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EsercizioW3D3
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Tickets"].ConnectionString; 

            SqlConnection conn = new SqlConnection(connectionString);

            try
            {
                string valoreSala = RadioButtonList1.SelectedValue;
                bool isChecked = Sconto.Checked;

                conn.Open();
                Response.Write("La connessione è stata correttamente aperta");

                SqlCommand cmdInser = new SqlCommand("INSERT INTO Ticket (Nome, Cognome, Sala, Tipo) VALUES (@Nome, @Cognome, @Sala, @Tipo)", conn);
                cmdInser.Parameters.AddWithValue("@Nome", TextNome.Text);
                cmdInser.Parameters.AddWithValue("@Cognome", TextCognome.Text);
                cmdInser.Parameters.AddWithValue("@Sala", valoreSala);
                cmdInser.Parameters.AddWithValue("@Tipo", isChecked);
                int affectedRows = cmdInser.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    Response.Write("Inserimento Riuscito");
                }
                else
                {
                    Response.Write("Inserimento non riuscito");
                }
            }
            catch (Exception ex)
            {
                Response.Write("La connessione non può essere aperta: " + ex.Message); 
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}