﻿using Memory_Thatcher.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Thatcher
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
			SetImagesArray();
		}


		Image[] imageArr;
		private bool m_IsFirst = true;
		private PictureBox m_FirstPictureBox;
		private PictureBox m_SecondPictureBox;




		private void Swap(int i, int j)
		{
			//Swaps 2 pictures in the image array
			Image imageTemp = imageArr[i];
			imageArr[i] = imageArr[j];
			imageArr[j] = imageTemp;
		}
		public void SetImagesArray()	
        {
			Image[] imageArrNew = { Resources.Pic1, Resources.Pic1, Resources.Pic2, Resources.Pic2,
				Resources.Pic3, Resources.Pic3, Resources.Pic4, Resources.Pic4 };
			Random rnd = new Random();
			imageArr = imageArrNew;
			for (int i = 0; i < imageArr.Length; i++)
			{
				Swap(i, rnd.Next(imageArr.Length));
			}
			

		}



		//Checks if 2 Images are the same image
		public bool IsImagesMatch(Image image1, Image image2)
		{
			try
			{
				//create instance or System.Drawing.ImageConverter to convert
				//each image to a byte array
				ImageConverter converter = new ImageConverter();
				//create 2 byte arrays, one for each image
				byte[] imgBytes1 = new byte[1];
				byte[] imgBytes2 = new byte[1];

				//convert images to byte array
				imgBytes1 = (byte[])converter.ConvertTo(image1, imgBytes2.GetType());
				imgBytes2 = (byte[])converter.ConvertTo(image2, imgBytes1.GetType());

				//now compute a hash for each image from the byte arrays
				System.Security.Cryptography.SHA256Managed sha = new System.Security.Cryptography.SHA256Managed();
				byte[] imgHash1 = sha.ComputeHash(imgBytes1);
				byte[] imgHash2 = sha.ComputeHash(imgBytes2);

				//now let's compare the hashes
				for (int i = 0; i < imgHash1.Length && i < imgHash2.Length; i++)
				{
					//whoops, found a non-match, exit the loop
					//with a false value
					if (!(imgHash1[i] == imgHash2[i]))
						return false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return false;
			}
			//we made it this far so the images must match
			return true;
		}


		

		private void Pic_Click(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            if (!IsImagesMatch(p.Image,Resources.Back)) p.Image = Resources.Back;
			else
			{
                int imageNum = int.Parse(p.Name.Substring(p.Name.Length - 1)) - 1;
				p.Image = imageArr[imageNum ];

			}

			if (!m_IsFirst) { m_SecondPictureBox = p; timer1.Start(); }
			else m_FirstPictureBox = p;

			m_IsFirst = !m_IsFirst;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
			if (!IsImagesMatch(m_FirstPictureBox.Image, m_SecondPictureBox.Image))
			{
				m_FirstPictureBox.Image = Resources.Back;
				m_SecondPictureBox.Image = Resources.Back;
			}

			timer1.Stop();
        }

    }
}
