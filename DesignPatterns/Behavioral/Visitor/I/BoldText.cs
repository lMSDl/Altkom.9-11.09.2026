namespace DesignPatterns.Behavioral.Visitor.I
{
    internal class BoldText : PlainText
    {
        override public string ToHtml()
        {
            return $"<b>{Text}</b>";
        }
    }
}
