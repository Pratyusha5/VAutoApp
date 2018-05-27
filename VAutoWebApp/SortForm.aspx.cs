using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections;

namespace VAutoApp
{
    public partial class SortForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string words = txtWords.Text;
                string[] wordsList = words.Split(new [] { " ", "\t","\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                Array.Sort(wordsList);
                int index = 0;
                int column = 4; int rem = (wordsList.Length) % column; int numcolumn = (int)Math.Ceiling((double)(wordsList.Length / column));
                string[,] wordmat = new string[numcolumn + 1, column];



                for (int j = 0; j < column; j++)
                {
                    numcolumn = (int)Math.Ceiling((double)(wordsList.Length / column));
                    if (rem > 0 && j < rem)
                    {
                        numcolumn++;
                    }

                    for (int i = 0; i < numcolumn; i++)
                    {
                        if (index < wordsList.Length)
                        {
                            wordmat[i, j] = wordsList[index];
                            index++;
                        }
                        else { break; }
                    }
                }
                GridView1.Visible = true;
                DataTable dt = new DataTable("Sort Words");
                dt.Columns.Add("column 0", Type.GetType("System.String"));
                dt.Columns.Add("column 1", Type.GetType("System.String"));
                dt.Columns.Add("column 2", Type.GetType("System.String"));
                dt.Columns.Add("column 3", Type.GetType("System.String"));

                for (int i = 0; i < wordmat.GetLength(0); i++)
                {
                    dt.Rows.Add();
                    dt.Rows[dt.Rows.Count - 1]["column 0"] = wordmat[i, 0];
                    dt.Rows[dt.Rows.Count - 1]["column 1"] = wordmat[i, 1];
                    dt.Rows[dt.Rows.Count - 1]["column 2"] = wordmat[i, 2];
                    dt.Rows[dt.Rows.Count - 1]["column 3"] = wordmat[i, 3];

                }

                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
                txtWords.Text = string.Empty;
                GridView1.DataSource = null;
                GridView1.DataBind();
        }
    }
}