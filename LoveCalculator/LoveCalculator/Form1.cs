using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoveCalculator {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        
        private void button_calculate_Click( object sender, EventArgs e ) {

            string name1 = textBox1.Text;
            string name2 = textBox2.Text;
            int sum1 = 0, sum2 = 0;
            double d_sum1, d_sum2, ans;
            
            foreach( char c in name1 ) {
                sum1 += ( Char.ToUpper( c ) - 'A' ) + 1;
            }

            foreach( char c in name2 ) {
                sum2 += ( Char.ToUpper( c ) - 'A' ) + 1;
            }

            sum1 %= 9;
            sum2 %= 9;

            sum1 = sum1 > 0 ? sum1 : 9 ;
            sum2 = sum2 > 0 ? sum2 : 9 ;

            d_sum1 = Convert.ToDouble( sum1 ) ;
            d_sum2 = Convert.ToDouble( sum2 );

            if( sum1 <= sum2 ) {
                ans = ( d_sum1 / d_sum2 ) * 100.0;
            } else {
                ans = ( d_sum2 / d_sum1 ) * 100.0;
            }

            MessageBox.Show( Convert.ToString( ans ) + "%" );
        }

        private void Form1_Load( object sender, EventArgs e ) {

        }
    }
}
