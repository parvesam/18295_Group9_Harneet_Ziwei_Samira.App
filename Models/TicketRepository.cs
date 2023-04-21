using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18295_Group9_Harneet_Ziwei_Samira.Models
{
    public static class TicketRepository
    {
        private static List<Ticket> tickets;

        static TicketRepository()
        {
            tickets = new List<Ticket>();
        }

        public static void CreateTicket(Schedule schedule, List<string> seatNumber)
        {
            foreach (string seat in seatNumber)
            {
                string ticketName = seat;
                Ticket ticket = new Ticket(schedule, seat);
                tickets.Add(ticket);
            }
        }

            public static List<Ticket> GetTickets()
            {
                return tickets;
            }
        
    } }
