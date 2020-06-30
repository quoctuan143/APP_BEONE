using BEONE.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BEONE.Models
{
  public class Inventory : BaseViewModel
    {
        public string Item_No { get; set; }
        public string Customer_No { get; set; }
        double _quantity =0;
        public double Quantity 
        {
            get => _quantity ; 
            set
            { 
                if (value != null )
                {
                    _quantity = value;
                    OnPropertyChanged(nameof(Amount));
                }    
            }
                
        }
        double _unit_price;
        public double Unit_Price { get => _unit_price ;
            set 
            {
                if (value != null)
                {
                    _unit_price = value;
                    OnPropertyChanged(nameof(Amount));
                }
            }
        }
        double _amount;
        public double Amount
        {
            get
            {
                _amount = Quantity * Unit_Price;
                return _amount;
            }
            set => _amount = value ;
            
        }

        public double Description { get; set; }
        public DateTime Posting_Date { get; set; } 
    }
}
