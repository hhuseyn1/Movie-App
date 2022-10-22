using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_App.MyControls;
#nullable disable
public partial class MovieControl : UserControl
{
    public MovieControl()
    {
        InitializeComponent();
    }
    public string Name
    {
        get => lbl_MovieName.Text;
        set => lbl_MovieName.Text = value;
    }

    public string Language
    {
        get => lbl_MovieLang.Text;
        set => lbl_MovieLang.Text = value;
    }
    public string Genre
    {
        get => lbl_MovieGenre.Text;
        set => lbl_MovieGenre.Text = value;
    }
    public string Poster { get; set; }

    
}
