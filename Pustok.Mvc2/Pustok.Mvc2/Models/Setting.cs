using Pustok.Mvc2.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace Pustok.Mvc2.Models
{
    public class Setting
    {
        [Key]
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
