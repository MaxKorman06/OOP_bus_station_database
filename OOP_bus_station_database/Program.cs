using System;

namespace OOP_bus_station_database
{
    class Program
    {
        public class BUS
        {
            private String name, booking;
            private int bus_num;
            private double level_var, price, drive_length;
            //Ввід імені
            public void setName(string name) 
            {
                this.name = name;
            }
            //Ввід бронювання
            public void setBooking(string booking)
            {
                this.booking = booking;
            }
            //Ввід імені автобуса
            public void setBus_num(int bus_num)
            {
                this.bus_num = bus_num;
            }
            //Ввід рівня змінності водіїв
            public void setLevel_var(double level_var)
            {
                this.level_var = level_var;
            }
            //Ввід ціни проїзду
            public void setPrice(double price)
            {
                this.price = price;
            }
            //Ввід довжини проїзду
            public void setDrive_length(double drive_length)
            {
                this.drive_length = drive_length;
            }
            //Отримання імені
            public string getName()
            {
                return name;
            }
            //Отримання бронювання
            public string getBooking()
            {
                return booking;
            }
            //Отримання імені автобуса
            public int getBus_num()
            {
                return bus_num;
            }
            //Отримання рівня змінності водіїв
            public double getLevel_var()
            {
                return level_var;
            }
            //Отримяння ціни проїзду
            public double getPrice()
            {
                return price;
            }
            //Отримання довжини проїзду
            public double getDrive_lenght()
            {
                return drive_length;
            }
            public BUS()
            { 
            
            }
            public BUS(string name, string booking, int bus_num, double level_var, double price, double drive_length)
            {
                setName(name);
                setBooking(booking);
                setBus_num(bus_num);
                setLevel_var(level_var);
                setPrice(price);
                setDrive_length(drive_length);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
