﻿using System.ComponentModel.DataAnnotations;

namespace SimpleSocialNetwork.ViewModels
{
    public enum Months
    {
        [Display(Name = "Январь")]
        Jan = 1,
        [Display(Name = "Февраль")]
        Feb = 2,
        [Display(Name = "Март")]
        March = 3,
        [Display(Name = "Апрель")]
        April = 4,
        [Display(Name = "Май")]
        May = 5,
        [Display(Name = "Июнь")]
        June = 6,
        [Display(Name = "Июль")]
        July = 7,
        [Display(Name = "Август")]
        Aug = 8,
        [Display(Name = "Сентябрь")]
        Sept = 9,
        [Display(Name = "Октябрь")]
        Oct = 10,
        [Display(Name = "Ноябрь")]
        Nov = 11,
        [Display(Name = "Декабрь")]
        Dec = 12,
    }
}
