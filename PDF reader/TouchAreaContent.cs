using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PDF_reader
{
	class TouchAreaContent
	{
		public TouchAreaContent(int count)
		{
			System.Windows.Forms.Label newlable = new System.Windows.Forms.Label();
			newlable.Name = "Lable" + (count + 1).ToString();
			newlable.AutoSize = true;
			newlable.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			//newlable.Location = new System.Drawing.Point(3, 10);
			newlable.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			newlable.Name = "label" + count.ToString();
			newlable.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
			newlable.Size = new System.Drawing.Size(53, 13);
			newlable.TabIndex = 0;
			newlable.Text = (count + 1).ToString();
			newlabel = newlable;

			System.Windows.Forms.Button firstbutton = new System.Windows.Forms.Button();
			firstbutton.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
			firstbutton.Name = "button" + ((count * 2) - 1).ToString();
			firstbutton.Size = new System.Drawing.Size(75, 23);
			firstbutton.TabIndex = 1;
			firstbutton.Text = "button" + ((count * 2) - 1).ToString();
			firstbutton.UseVisualStyleBackColor = true;
			firstButton = firstbutton;

			System.Windows.Forms.Button secondbutton = new System.Windows.Forms.Button();
			secondbutton.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
			secondbutton.Name = "button" + ((count * 2) - 1).ToString();
			secondbutton.Size = new System.Drawing.Size(75, 23);
			secondbutton.TabIndex = 2;
			secondbutton.Text = "button" + ((count * 2) - 1).ToString();
			secondbutton.UseVisualStyleBackColor = true;
			secondButton = secondbutton;
		}

		public Label newlabel
		{
			get; set;
		}

		public Button firstButton
		{
			get; set;
		}

		public Button secondButton
		{
			get; set;
		}


	}
}
