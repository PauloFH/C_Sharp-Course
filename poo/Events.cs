using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo {
    public class CineROOM {
        private int seatsInUse = 0;

        public event EventHandler RoomSoldOut;
        
        protected virtual void OnRoomSoldOut(EventArgs e) {
            EventHandler handler = RoomSoldOut;
            handler?.Invoke(this, e);
        }

        public int Seats { get; set; }
        public CineROOM(int seats) {
            Seats = seats;
        }
        public void ReserveSeat() {
            seatsInUse++;
            if (seatsInUse > Seats) {
               OnRoomSoldOut(EventArgs.Empty);
               
            } else {
                Console.WriteLine("Reserved");
            }
        }
    }
        internal class Events {

        public static void Events_test() {
                var cine = new CineROOM(3);
            cine.RoomSoldOut += OnRoomSoldOut;
            cine.ReserveSeat();
            cine.ReserveSeat();
            cine.ReserveSeat();
            cine.ReserveSeat();

        }

         static void OnRoomSoldOut(object? sender, EventArgs e) {
            Console.WriteLine("No more seats");
        }


    }
    
    }

