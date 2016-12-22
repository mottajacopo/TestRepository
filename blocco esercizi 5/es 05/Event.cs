using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_05
{
    public class Event : IEnumerable<Participant>
    {
        List<Participant> participants = new List<Participant>();

        public void AddParticipant(Participant partc)
        {
            participants.Add(partc);
        }

        public IEnumerator<Participant> GetEnumerator()
        {
            foreach (Participant partc in participants)
            {
                yield return partc;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
