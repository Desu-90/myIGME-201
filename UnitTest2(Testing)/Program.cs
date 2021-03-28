using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest2_Testing_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Tardis tardis = new Tardis();
            PhoneBooth booth = new PhoneBooth();
            
        }
    }

        public abstract class Phone
        {
            private string phoneNumber;
            public string address;

            public string PhoneNumber;
            public abstract void Connect();

            public abstract void Disconnect();
        }

        public interface PhoneInterFace
        {
            void Answer();
            void MakeCall();
            void HangUp();
        }
        public class RotaryPhone : Phone, PhoneInterFace
        {
            public void Answer()
            {
            }

            public void MakeCall()
            {
            }

            public void HangUp()
            {
            }

            public override void Connect()
            {
            }
            public override void Disconnect()
            {
            }
        }

        public class PushButtonPhone : Phone, PhoneInterFace
        {
            public void Answer()
            {
            }

            public void MakeCall()
            {
            }

            public void HangUp()
            {
            }

            public override void Connect()
            {
            }
            public override void Disconnect()
            {
            }
        }

        public class Tardis : RotaryPhone
        {
            private bool sonicScrewdriver;
            private byte whichDrWho;
            private string femaleSideKick;
            public double exteriorSurfaceArea;
            public double interiorVolume;

            public byte WhichDrWho
            {
                get;
            }
            public string FemaleSideKick
            {
                get;
            }

            public void TimeTravel()
            {
            }
            public static bool operator >(Tardis dr1, Tardis dr2)
            {
                bool returnVal = (dr1.whichDrWho > dr2.whichDrWho);

                if (dr1.whichDrWho == 10)
                {
                    returnVal = true;
                }

                else if (dr2.whichDrWho == 10)
                {
                    returnVal = false;
                }

                else
                {
                    return returnVal;
                }
                return returnVal;
            }
            public static bool operator <(Tardis dr1, Tardis dr2)
            {
                bool returnVal = (dr1.whichDrWho < dr2.whichDrWho);

                if (dr1.whichDrWho == 10)
                {
                    returnVal = false;
                }

                else if (dr2.whichDrWho == 10)
                {
                    returnVal = true;
                }

                else
                {
                    return returnVal;
                }

                return returnVal;
            }
            public static bool operator >=(Tardis dr1, Tardis dr2)
            {
                bool returnVal = (dr1.whichDrWho >= dr2.whichDrWho);

                if (dr1.whichDrWho == 10)
                {
                    returnVal = true;
                }

                else if (dr2.whichDrWho == 10)
                {
                    returnVal = false;
                }

                else
                {
                    return returnVal;
                }
                return returnVal;
            }
            public static bool operator <=(Tardis dr1, Tardis dr2)
            {
                bool returnVal = (dr1.whichDrWho <= dr2.whichDrWho);

                if (dr1.whichDrWho == 10)
                {
                    returnVal = false;
                }

                else if (dr2.whichDrWho == 10)
                {
                    returnVal = true;
                }

                else
                {
                    return returnVal;
                }

                return returnVal;
            }
            public static bool operator ==(Tardis dr1, Tardis dr2)
            {
                return (dr1.whichDrWho == dr2.whichDrWho);
            }
            public static bool operator !=(Tardis dr1, Tardis dr2)
            {
                return !(dr1.whichDrWho == dr2.whichDrWho);
            }

            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }
            public override int GetHashCode()
            {
                return whichDrWho;
            }
        }


        public class PhoneBooth : PushButtonPhone
        {
            private bool superMan;
            public double costPerCall;
            public bool phoneBook;

            public void OpenDoor()
            {
            }
            public void CloseDoor()
            {
            }
        }


    }
