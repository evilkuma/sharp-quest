using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

class GUI : Form{
	public GUI() {
		Text = "Test";
		FormBorderStyle = FormBorderStyle.FixedDialog;
		MaximizeBox = false;
		MinimizeBox = false;

		Size = new Size(800, 600);
		// Width = 800;
		// Height = 600;

		Paint += new PaintEventHandler(OnPaint);
	}

	void OnPaint(object sender, PaintEventArgs e) {      
        Graphics g = e.Graphics;
        Pen pen = new Pen(Color.Black, 1);

        g.DrawLine(pen, 20, 40, 250, 40);
        g.Dispose();
	}
}

class MAplication {
	public static void Main() {
		Application.Run(new GUI());
	}
}
