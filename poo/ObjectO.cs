using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace poo {

    internal class ObjectO {
        internal class Car {
            protected readonly int maxSpeed;
            int speed;
            public int Speed {
                get => speed;
            }
            public Car(int maxSpeed) {
                this.maxSpeed = maxSpeed;
            }

            protected int ChangeSpeed(int delta) {
                int currentSpeed = speed + delta;
                if (currentSpeed < 0) {
                    currentSpeed = 0;
                } else if (currentSpeed > maxSpeed) {
                    currentSpeed = maxSpeed;
                }
                this.speed = currentSpeed;
                return this.speed;
            }

            public int Accelerate(int delta) {
                return ChangeSpeed(delta);
            }
            public virtual int Accelerate() {
                return ChangeSpeed(5);
            }
            public int Decelerate() {
                ChangeSpeed(-5);
                return this.speed;
            }

        }

        public class Uno : Car {

            public Uno() : base(500) {

            }

        }
        public class Ferrari : Car {

            public Ferrari() : base(350) {

            }
            public override int Accelerate() {
                return ChangeSpeed(20);
            }
            public new int Decelerate() {
                return ChangeSpeed(-20);
            }

        }
        public static void ObjectO_test() {
            //Uno car1 = new Uno();
            //Ferrari ferrari = new Ferrari();
            //for (int i = 0; i < 10; i++) {
            //    car1.Accelerate();
            //    ferrari.Accelerate();
            //    Console.WriteLine($"UNO: {car1.Speed} Ferrari: {ferrari.Speed}");
            //}
            //for (int i = 0; i < 10; i++) {
            //    car1.Decelerate();
            //    ferrari.Decelerate();
            //    Console.WriteLine($"UNO: {car1.Speed} Ferrari: {ferrari.Speed}");
            //}
            //Console.WriteLine("uno");

            var dog = new Dog("Pincher", 2.4M);
            Console.WriteLine(dog.ToString());

        }
        private class Animal {
            public string Name { get; set; }
            public Animal(string name) {
                Name = name;
            }

        }
        private class Dog : Animal {
            public Decimal Size { get; set; }
            public Dog(string name): base(name) {
                Console.WriteLine("Dog: {0}",name);
            }
            public Dog(string name, Decimal size) : this(name) { 
                Size = size;
            }

            public override string ToString() { 
                return $"{Name} has {Size} size";
            }
        }
    }

}

