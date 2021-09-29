using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    public class Chatroom : IChatroom
    {
        private Dictionary<string, Participant> participants = new Dictionary<string, Participant>();
        public void Register(Participant participant)
        {
            if(!participants.ContainsKey(participant.Name))
            {
                participants[participant.Name] = participant;
            }

            participant.chatroom = this;
        }

        public void Send(string from, string to, string message)
        {
            Participant participant = participants[to];

            if(participant != null)
            {
                participant.Receive(from, message);
            }
        }
    }
}
