namespace AulaPOOCelular
{
    public class phone
    {
        public string color;
        public string model;
        public string size;
        public string person;
        public string message;
        public bool on = false;


        public void turnon(){
            on = true;
        }

        public void turnoff(){
            on = false;
        }

        public string menu(){
            string menu = $@"
            =============================
            |                           |
                      {model}           
            |                           |
            |                           |
            |                           |
            |           MENU            |        
            |                           | 
            |                           |
            |                           |
            |                           |
            |   [1] - Fazer Ligação     |
            |   [2] - Envia Mensagem    |
            |   [3] - Desligar          |
            |                           |
            |                           |
            |                           |
            |                           |
            |                           |
            |                           |    
            =============================
            ";
            return menu;
        }
        public string call(){
            string calling = $@"
            =============================
            |                           |
              Ligando para: {person}         
            |                           |
            |                           |
            |                           |
            |           0   0           |        
            |           _____           | 
            |                           |
            |                           |
            |                           |
            |  O telefone não consegue  |
            |  receber esse tipo de     |
            |  chamada nesse momento    |
            |                           |
            |                           |
            |                           |
            |                           |
            |                           |
            |                           |    
            =============================
            ";
            return calling;
        }
        public string sms(){
            string chat = $@"
            =============================
            |                           |
            |         MENSAGEM          |
                        {person}          
            |                           |
            |                           |
            |   ========================|        
            |   |  {message}            | 
            |   ========================|
            |                           |
            |                           |
            |                           |
            |                           |
            |                           |
            |                           |
            |                           |
            |                           |
            |                           |
            |                           |
            |                           |    
            =============================
            ";
            return chat;
        }
    }
}