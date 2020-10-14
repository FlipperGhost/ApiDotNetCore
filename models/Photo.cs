using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace apiRestFul.Models{


 public class Photo
    {
        [Key]
        public int id {get; set; }
        
            [Required(ErrorMessage = "O Path do arquivo é Obrigatório")]
            [MinLength(9, ErrorMessage = "Este campo deve conter no máximo 9 caracteres")]
            public string path {get; set;}


    
        




    }

}

