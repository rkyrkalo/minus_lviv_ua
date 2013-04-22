using System.Collections.Generic;

namespace ClientMinus.Models.Messages
{
    public class MessageManager
    {
        /// <summary>
        /// Returns all messages that were received by the given user and are not marked as deleted.
        /// </summary>
        /// <returns></returns>
        public List<Message> InboxFor()
        {
            return null;
        }

        /// <summary>
        /// eturns all messages that were sent by the given user and are not marked as deleted.
        /// </summary>
        /// <returns></returns>
        public List<Message> OutboxFor()
        {
            return null;
        }

        /// <summary>
        /// Returns all messages that were either received or sent by the given user and are marked as deleted.
        /// </summary>
        /// <returns></returns>
        public List<Message> TrashFor()
        {
            return null;
        }
    }
}