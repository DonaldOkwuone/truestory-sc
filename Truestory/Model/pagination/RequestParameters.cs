namespace Truestory.model.pagination
{
    public abstract class RequestParameters
    {
        const int maxPage = 10;

        public int pageNum { get; set; } = 1;

        private int _pageSize = 10;
        public int pageSize
        {
            get
            {
                return _pageSize;

            }
            set
            {
                _pageSize = value > maxPage ? value : maxPage;
            }
        }
    }
}
