using System;
using System.IO;
using System.Windows.Forms;

namespace FifthAssignment
{
    /// <summary>
    /// Class: GridViewForm: This class provide the data stored in the DB to the user in grid Format.
    /// </summary>
    public partial class GridViewForm : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public GridViewForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// EventHandler: It retrieve the data from DB & disp in gridview format. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridViewForm_Load(object sender, EventArgs e)
        {
            bool error = false;
            // TODO: This line of code loads data into the 'lemeDataSet.Table' table. You can move, or remove it, as needed.
            try
            {
                this.tableTableAdapter.Fill(this.lemeDataSet.Table);
            }
            catch (Exception expMsg)
            {
                string fileName = "Logfile.txt";
                File.AppendAllText(fileName, expMsg.ToString() + "\n");
                error = true;
                MessageBox.Show("application ran into an error");
            }
            finally
            {
                if(error)
                    this.Close();
            }


        }
    }
}
