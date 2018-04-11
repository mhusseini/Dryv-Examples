using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dryv.Demo.Models
{
    public class Model8
    {
        public static readonly DryvRules Rules = DryvRules
            .For<Model8>()
            .Rule(m => m.Name,
                m => !m.IsManly || m.Name.EndsWith("or")
                        ? DryvResult.Success
                        : DryvResult.Error("Overly manly names must end with 'or'."));

        [Required]
        [DryvRules]
        public string Name { get; set; }

        [DisplayName("Is overly manly")]
        public bool IsManly { get; set; }
    }
}