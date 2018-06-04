using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

#region GİTHUB
// alierguc https://github.com/alierguc
#endregion

namespace Hareketliİmlec
{
    public partial class Anaform : Form
    {
        public Anaform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("alierguc", "https://github.com/alierguc");
        }

        private void Anaform_Load(object sender, EventArgs e)
        {
            try
            {
                //dosyasını c#'a gömdüğümüz cursorun adresi.
                //Path Nesnesini görmesi için Sınıfa Using.System.IO; eklenmesi gerekmetedir.
                this.Cursor = AnimatedCurs.Create(Path.Combine(Application.StartupPath, "cursor.ani"));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
        #region İmleç sınıfı
        public class AnimatedCurs
        {
            [DllImport("User32.dll")]
            private static extern IntPtr LoadCursorFromFile(String str);
            public static Cursor Create(string fname)
            {
                // imleç atama işlemi.
                IntPtr HC = LoadCursorFromFile(fname);
                // İmleç Geçişinin başarılı olup olmadığını kontrol etmek için kullanılan koşul.
                if (!IntPtr.Zero.Equals(HC))
                {
                    return new Cursor(HC);
                }
                else
                {
                    throw new ApplicationException("İmleç dosyası bulunamadı. " + fname);
                }
            }
        }
    }
    #endregion

}

