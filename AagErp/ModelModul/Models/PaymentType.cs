﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ModelModul.Models
{
    public class PaymentType : ModelBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PaymentType()
        {
            Counterparties = new HashSet<Counterparty>();
        }

        private int _id;
        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged("Id");
            }
        }

        private string _code;
        [Required]
        [StringLength(20)]
        public string Code
        {
            get => _code;
            set
            {
                _code = value;
                OnPropertyChanged("Code");
            }
        }

        private string _description;
        [Required]
        [StringLength(50)]
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged("Description");
            }
        }

        private ICollection<Counterparty> _counterparties;
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Counterparty> Counterparties
        {
            get => _counterparties;
            set
            {
                _counterparties = value;
                OnPropertyChanged("Counterparties");
            }
        }
    }
}