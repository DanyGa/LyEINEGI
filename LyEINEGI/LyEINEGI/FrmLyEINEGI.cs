using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xls = Microsoft.Office.Interop.Excel;

namespace LyEINEGI
{
    public partial class FrmLyEINEGI : Form
    {
        public FrmLyEINEGI()
        {
            InitializeComponent();
        }

        xls.Application a = new xls.Application();
        int i = 6;
        int x;
        string entF;
        string grupo;
        string hom5;
        string muj5;
        string hom10;
        string muj10;
        string hom20;
        string muj20;

        private void FrmLyEINEGI_Load(object sender, EventArgs e)
        {
            a.Workbooks.Open(Application.StartupPath + @"\Poblacion_01.xlsx");
            while (a.ActiveWorkbook.ActiveSheet.Cells(i, 1).Value != null)
            {
                i++;
            }
            i--;
        }

        private void btnEntidad_Click(object sender, EventArgs e)
        {
            lvLista.Items.Clear();
            x = 6;
            string entidad = cbEntidad.Text;
            int cont = 0;
            entF = a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value.ToString();

            while (entF != entidad)
            {
                x += 22;
                entF = a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value.ToString();
            }
            while (cont < 22)
            {
                try
                {
                    entF = a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value.ToString();
                }
                catch
                {
                    entF = "";
                }
                grupo = a.ActiveWorkbook.ActiveSheet.Cells(x, 2).Value.ToString();
                hom5 = a.ActiveWorkbook.ActiveSheet.Cells(x, 3).Value.ToString();
                muj5 = a.ActiveWorkbook.ActiveSheet.Cells(x, 4).Value.ToString();
                hom10 = a.ActiveWorkbook.ActiveSheet.Cells(x, 5).Value.ToString();
                muj10 = a.ActiveWorkbook.ActiveSheet.Cells(x, 6).Value.ToString();
                hom20 = a.ActiveWorkbook.ActiveSheet.Cells(x, 7).Value.ToString();
                muj20 = a.ActiveWorkbook.ActiveSheet.Cells(x, 8).Value.ToString();

                ListViewItem lista = new ListViewItem(entF);

                lista.SubItems.Add(grupo);
                lista.SubItems.Add(hom5);
                lista.SubItems.Add(muj5);
                lista.SubItems.Add(hom10);
                lista.SubItems.Add(muj10);
                lista.SubItems.Add(hom20);
                lista.SubItems.Add(muj20);
                lvLista.Items.Add(lista);
                x++;
                cont++;
            }
        }
    }
}
