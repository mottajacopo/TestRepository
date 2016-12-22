using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using es_05;

namespace UnitTestBlocco5
{
   
    [TestClass]
    public class es05Test
    {
        [TestMethod]
        public void TestEvent()
        {
           
            Event newEvent = new Event();
            newEvent.AddParticipant(new Participant() { Age = 20, Name = "pippo" });
            newEvent.AddParticipant(new Participant() { Age = 35, Name = "paperino" });
            newEvent.AddParticipant(new Participant() { Age = 28, Name = "pluto" });

            int[] partcAge  = { 20, 35, 28 };
            string[] partcName = { "pippo", "paperino", "pluto" };

            int c = 0;
            foreach (Participant partc in newEvent)
             {
                
                Assert.AreEqual(partcName[c], partc.Name);
                 c++;
             }
            
             int i = 0;
             foreach (Participant partc in newEvent)
             {
                 Assert.AreEqual(partcAge[i], partc.Age);
                 i++;
             }
        }
    }
}
