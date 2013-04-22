namespace ClientMinus.Models.MinusStore
{
    /// <summary>
    /// Integrative glue-model for notifying users about comments
    /// </summary>
    public class CommentNotify
    {
        public object Comment { get; set; }

        public object ContentType { get; set; }

        public object ObjectId { get; set; }

        public object ContentObject { get; set; }

        public object User { get; set; }

        public object IsSeen { get; set; }

    }
}