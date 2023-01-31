using FirstTeamCore.Models;

namespace FirstTeamCore.ViewModel
{
    public class CSetOrderDetailViewModel
    {
        private SetOrderDetail _product;
        public SetOrderDetail Product
        {
            get { return _product; }
            set { _product = value; }
        }

        public CSetOrderDetailViewModel()
        {
            _product = new SetOrderDetail();
        }
        public int 套裝行程ID
        {
            get { return _product.套裝行程id; }
            set { _product.套裝行程id = value; }
        }
        public int? 營地ID
        {
            get { return _product.營地id; }
            set { _product.營地id = value; }
        }
        public int? 營地細項編號
        {
            get { return _product.營區細項編號; }
            set { _product.營區細項編號 = value; }
        }
        public int? 餐廳ID
        {
            get { return _product.餐廳id; }
            set { _product.餐廳id = value; }
        }
        public string? 套裝方案
        {
            get { return _product.套裝方案; }
            set { _product.套裝方案 = value; }
        }
        public string? 套裝細項
        {
            get { return _product.套裝細項; }
            set { _product.套裝細項 = value; }
        }
        public int? 露營天數
        {
            get { return _product.露營天數; }
            set { _product.露營天數 = value; }
        }
        public int? 套裝行程價格
        {
            get { return _product.套裝行程價格; }
            set { _product.套裝行程價格 = value; }
        }
    }
}
