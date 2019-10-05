using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS21A_Final_Project
{
    class ReliefCenter
    {
        string reliefcenterName;
        int releasePacks;
        List<ReliefGood> listOfGoods;

        public ReliefCenter(string n)
        {
            reliefcenterName = n;
            releasePacks = 0;
            listOfGoods = new List<ReliefGood>();
        }

        public string GetName()
        {
            /// Returns the name of the ReliefCenter
            return reliefcenterName;

        }

        public int GetPackCount()
        {
            /// Returns the total number of packs the relief center has released
            return releasePacks;
        }

        public string PrintInventory()
        {
            string writeLine = "";

            writeLine += "=== INVENTORY === \n";
            writeLine += "Total Packs Released:" + releasePacks;
            writeLine += "\n ================= \n";

            foreach (ReliefGood good in listOfGoods)
            {
                writeLine += good.GetName() + ": " + good.GetUnitsLeft() + good.GetUnit() + "\n";
            }
            writeLine += " ================= \n";

            return writeLine;
        }

        public string ReceiveGoods(string good, int num)
        {
            string writeLine = "";

            if (FindGood(good) != null)
            {
                FindGood(good).AddGoods(num);

                writeLine = good + " " + num + FindGood(good).GetUnit() + " added. Thank you for donating! \n ================= \n";
            }

            else
            {
                writeLine = good + "is not accepted. Sorry! \n ================= \n";
            }

            return writeLine;
        }

        public string ReleasePacks(int num)
        {
            bool detect = true;
            string writeLine = "";

            foreach (ReliefGood good in listOfGoods)
            {
                if (good.GetUnitsLeft() < good.GetReleaseRate() * num)
                {
                    detect = false;
                }
                
            }

            if (detect == true)
            {
                for (int a = 0; a < num; a++)
                {
                    foreach (ReliefGood good in listOfGoods)
                    {
                        good.ReleaseGoods();
                    }

                    releasePacks += 1;
                }
                writeLine = "Released " + num + " packs. \n ================= \n";
            }
            
            else
            {
                writeLine = "Insufficient supplies. Sorry! \n ================= \n";
            }

            return writeLine;
        }

        public string AddNewGood(string n, int r, string u)
        {
            n = n.ToLower();
            string writeLine = "";

            if (FindGood(n) == null)
            {
                listOfGoods.Add(new ReliefGood(n, r, u));

                writeLine = n + " " + r + u + "/ pack now being accepted! \n ================= \n";
            }

            else
            {
                writeLine = n + " is already being accepted! \n ================= \n";
            }

            return writeLine;
        }

        public ReliefGood FindGood(string g)
        {
            g = g.ToLower();
            ReliefGood foundGood = null;

            foreach (ReliefGood good in listOfGoods)
            {
                if (good.GetName().ToLower() == g)
                {
                    foundGood = good;
                }
            }
            
            return foundGood;
        }
    }
}
