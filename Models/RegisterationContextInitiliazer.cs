// using apoptoosi.models;
// using Microsoft.EntityFrameworkCore;


// namespace apoptoosi.initilzation {

//     public class RegisterationDbContextInitiliazer : DropCreateDatabaseAlways<RegisterirationContext>
//     {
//         protected override void Seed(RegisterirationContext context)
//         {

//                 var seed1 = new Registeriration{
//                     name = "Hello", 
//                     group = "World", 
//                     alcohol = false, 
//                     text = "Apoptoosi1"
//                 };
//                 var seed2 = new Registeriration{
//                     name = "Joonas", 
//                     group = "Panosuo", 
//                     alcohol = false, 
//                     text = "Apoptoosi2"
//                 };
//                 var seed3 = new Registeriration{
//                     name = "Ebinest", 
//                     group = "Brummenator", 
//                     alcohol = false, 
//                     text = "Apoptoosi3"
//                 };

//             context.Registerirations.Add(seed1);
//             context.Registerirations.Add(seed1);
//             context.Registerirations.Add(seed1);

//             base.Seed(context);

//         }
//     }
// }