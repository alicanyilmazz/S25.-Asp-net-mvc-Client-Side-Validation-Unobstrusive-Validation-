using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataAnnotations_sample.Models
{
    public class User
    {
        [DisplayName("your name"),
            Required(ErrorMessage ="name field is required."),
            MinLength(3,ErrorMessage = "The field {0} must be a string or array type with a minimum length of '{1}'."),
            MaxLength(20,ErrorMessage = "The field {0} must be a string or array type with a maximum length of '{1}'.")]
        public String name { get; set; }

        [DisplayName("your surname"),
            Required(ErrorMessage = "{0} field is reqired."), 
            MinLength(3, ErrorMessage = "The field {0} must be a string or array type with a minimum length of '{1}'."),
            MaxLength(20, ErrorMessage = "The field {0} must be a string or array type with a maximum length of '{1}'.")]
        public string surname { get; set; }

        [DisplayName("your age"),
            Required(ErrorMessage = "{0} field is required."),
            Range(1,110,ErrorMessage = "The field {0} must be between {1} and {2}.")]
        public int age { get; set; }

        [DisplayName("your username"),
            Required(ErrorMessage = "{0} field is reqired."),
            MinLength(5,ErrorMessage = "The field {0} must be a string or array type with a minimum length of '{1}'."),
            MaxLength(25,ErrorMessage = "The field {0} must be a string or array type with a maximum length of '{1}'.")]
        public string user_name { get; set; }

        [DisplayName("your password")
            ,Required(ErrorMessage ="password field is requied."), 
            MinLength(6,ErrorMessage = "The field {0} must be a string or array type with a minimum length of '{1}'."),
            MaxLength(16,ErrorMessage = "The field {0} must be a string or array type with a maximum length of '{1}'."),
            DataType(DataType.Password)]
        public string password { get; set; }

        [DisplayName("your password (verify)"),
            Required(ErrorMessage = "{0} field is required."),
            MinLength(6,ErrorMessage = "The field {0} must be a string or array type with a minimum length of '{1}'."), 
            MaxLength(16,ErrorMessage = "The field {0} must be a string or array type with a maximum length of '{1}'."), 
            DataType(DataType.Password),
            Compare(nameof(password),ErrorMessage = "'{0}' and 'your password' do not match.")] // Compare("password") de kullanılabilir farkı video da anlatılıyor.
        public string password_2 { get; set; }

        [DisplayName("your e-mail"),
            Required(ErrorMessage = "{0} filed is reqired."),
            MinLength(5,ErrorMessage = "The field {0} must be a string or array type with a minimum length of '{1}'."),
            MaxLength(60,ErrorMessage = "The field {0} must be a string or array type with a maximum length of '{1}'."),
            DataType(DataType.EmailAddress), 
            RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail type is not valid")] //EmailAddress() seklindede dogrudan kullanılabilir.
        public string e_mail { get; set; }

        [DisplayName("your e-mail (verify)"),
            Required(ErrorMessage = "{0} field is required."),
            MinLength(5, ErrorMessage = "The field {0} must be a string or array type with a minimum length of '{1}'."), //ErrorMessage özelliğini kullanmazsanız Automatic message özelliğinden dolayı otomatik mesaj basar ekrana.
            MaxLength(60, ErrorMessage = "The field {0} must be a string or array type with a maximum length of '{1}'."),
            DataType(DataType.EmailAddress),
            Compare(nameof(e_mail),ErrorMessage = "'{0}' and 'your e-mail' do not match."),
            RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail type is not valid")] //EmailAddress() seklindede dogrudan kullanılabilir.
        public string e_mail_2 { get; set; }

        [DisplayName("your team")]
        public string  team { get; set; }
    }
}


// her inputun attribute 'unun ErrorMessage özelliği bulunmaktadır ve bu özellik istenen her özellik için ErrorMessage özelliği eklenebilir.
// Biz ErrorMessage özelliğini kullanırken mesajları hiçbir şekilde ErrorMessage kullanmakdıgımızda otomatik olarak Attribute özelliğine bağlı olarak çıkan
// Range(),Min(),Max() gibi özelliğine baglı olarak cıkarılan otomatik mesajları ErrorMessage bölümüne yazdık siz isteğiniz gibi bu mesajları değiştirebilirsiniz.

