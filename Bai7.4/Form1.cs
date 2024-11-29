using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7._4
{
    public partial class Form1 : Form
    {
        private const int SeatCount = 30;
        private const int TicketPrice = 100000; 
        private List<Button> selectedSeats = new List<Button>();
        private HashSet<int> soldSeats = new HashSet<int> { 2, 5, 15, 20 };
        public Form1()
        {
            InitializeComponent();
            LoadSeats();
        }
        private void LoadSeats()
        {
            flowLayoutPanelSeats.Controls.Clear();

            for (int i = 1; i <= SeatCount; i++)
            {
                Button seat = new Button
                {
                    Text = i.ToString(),
                    Width = 50,
                    Height = 50,
                    BackColor = soldSeats.Contains(i) ? Color.Yellow : Color.White,
                    Tag = i
                };

                seat.Click += Seat_Click;
                flowLayoutPanelSeats.Controls.Add(seat);
            }
        }
        private void Seat_Click(object sender, EventArgs e)
        {
            Button seat = sender as Button;

            if (seat != null)
            {
                int seatNumber = (int)seat.Tag;

                if (soldSeats.Contains(seatNumber))
                {
                    MessageBox.Show($"Ghế {seatNumber} đã bán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (seat.BackColor == Color.White)
                {
                    seat.BackColor = Color.Blue;
                    selectedSeats.Add(seat);
                }
                else if (seat.BackColor == Color.Blue)
                {
                    seat.BackColor = Color.White;
                    selectedSeats.Remove(seat);
                }
            }

            UpdateTotalPrice();
        }
        private void UpdateTotalPrice()
        {
            int totalPrice = selectedSeats.Count * TicketPrice;
            lblTotalPrice.Text = $"Thành tiền: {totalPrice:N0} VND";
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            foreach (Button seat in selectedSeats)
            {
                seat.BackColor = Color.Yellow;
                soldSeats.Add((int)seat.Tag);
            }

            selectedSeats.Clear();
            UpdateTotalPrice();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach (Button seat in selectedSeats)
            {
                seat.BackColor = Color.White;
            }

            selectedSeats.Clear();
            UpdateTotalPrice();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
