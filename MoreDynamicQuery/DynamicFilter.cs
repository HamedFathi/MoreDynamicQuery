namespace MoreDynamicQuery
{
    public class DynamicFilter
    {
        public string PropertyName { get; set; }
        public ComparisonFilter ComparisonFilter { get; set; }
        public object PropertyValue { get; set; }
    }
}
