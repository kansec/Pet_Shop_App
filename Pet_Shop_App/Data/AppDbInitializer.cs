using Pet_Shop_App.Models;



namespace Pet_Shop_App.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                
                if (!context.Owners.Any())
                {
                    context.Owners.AddRange(new List<Owner>(){
                        new Owner()
                        {
                            FirstName = "Madam",
                            LastName = "Martha",
                            Email = "mm@gmail.com",
                            PhoneNumber = 1234142,

                        },
                        new Owner()
                        {
                            FirstName = "Franz",
                            LastName = "Kafka",
                            Email = "fk@gmail.com",
                            PhoneNumber = 313213,

                        },
                        new Owner()
                        {
                            FirstName = "Harry",
                            LastName = "Potter",
                            Email = "hp@gmail.com",
                            PhoneNumber = 3247324,

                        }

                    });
                    context.SaveChanges();

                }

                if (!context.Treatments.Any())
                {
                    context.Treatments.AddRange(new List<Treatment>() {

                        new Treatment()
                        {
                            Name = "Sterilization",
                            Price = 300

                        },
                        new Treatment()
                        {
                            Name = "Examination",
                            Price = 100
                        },
                        new Treatment()
                        {
                            Name = "Vaccination",
                            Price = 200

                        },


                    });
                    context.SaveChanges();

                }

                if (!context.PetCategories.Any())
                {
                    context.PetCategories.AddRange(new List<PetCategory>() {

                        new PetCategory()
                        {
                            Name = "Cat"
                        },
                        new PetCategory()
                        {
                            Name = "Dog"
                        },
                        new PetCategory()
                        {
                            Name = "Bird"
                        }

                    });
                    context.SaveChanges();
                }

                if (!context.Vets.Any())
                {
                    context.Vets.AddRange(new List<Vet>()
                    {

                        new Vet()
                        {
                            FirstName = "Bruce",
                            LastName = "Lee",
                            Age = 32,
                            PhoneNumber = 123124421,
                            Title = "Prof"

                        },
                        new Vet()
                        {
                            FirstName = "Bruce",
                            LastName = "Lee",
                            Age = 19,
                            PhoneNumber = 54345345,
                            Title = "Intern"

                        },
                        new Vet()
                        {
                            FirstName = "Bruce",
                            LastName = "Lee",
                            Age = 67,
                            PhoneNumber = 31312312,
                            Title = "Expert"

                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Pets.Any())
                {
                    context.Pets.AddRange(new List<Pet>()
                    {
                        new Pet()
                        {
                            OwnerId = 1,
                            Name = "Rocky",
                            Age = 3,
                            PetCategoryId = 3
                        },
                        new Pet()
                        {
                            OwnerId = 2,
                            Name = "Joshua",
                            Age = 8,
                            PetCategoryId = 2
                        },
                        new Pet()
                        {
                            OwnerId = 2,
                            Name = "Vercetti",
                            Age = 7,
                            PetCategoryId = 1
                        },
                        new Pet()
                        {
                            OwnerId = 1,
                            Name = "Lolipop",
                            Age = 1,
                            PetCategoryId = 1
                        },
                        new Pet()
                        {
                            OwnerId = 3,
                            Name = "Shhippo",
                            Age = 32,
                            PetCategoryId = 2
                        }
                    });
                    context.SaveChanges();

                }


                if (!context.Operations.Any())
                {
                    context.Operations.AddRange(new List<Operation> {
                        new Operation()
                        {
                            Date = new DateTime(2015,2,2),
                            PetId = 1,
                            TreatmentId = 1,

                        },
                        new Operation()
                        {
                            Date = new DateTime(2015,3,2),
                            PetId = 2,
                            TreatmentId = 3,

                        },
                        new Operation()
                        {
                            Date = new DateTime(2015,4,2),
                            PetId = 2,
                            TreatmentId = 2,

                        },
                        new Operation()
                        {
                            Date = new DateTime(2015,5,2),
                            PetId = 3,
                            TreatmentId = 1,

                        },
                        new Operation()
                        {
                            Date = new DateTime(2015,6,2),
                            PetId = 4,
                            TreatmentId = 3,

                        },
                        new Operation()
                        {
                            Date = new DateTime(2015,7,2),
                            PetId = 5,
                            TreatmentId = 1,

                        },

                    });
                    context.SaveChanges();
                }

                if (!context.OperationsVets.Any())
                {
                    context.OperationsVets.AddRange(new List<Operation_Vet>
                    {
                        new Operation_Vet()
                        {
                            OperationId = 1,
                            VetId = 1,
                        },
                        new Operation_Vet()
                        {
                            OperationId = 1,
                            VetId = 2,
                        },
                        new Operation_Vet()
                        {
                            OperationId = 2,
                            VetId = 2,
                        },
                        new Operation_Vet()
                        {
                            OperationId = 2,
                            VetId = 3,
                        },
                        new Operation_Vet()
                        {
                            OperationId = 2,
                            VetId = 1,
                        },
                        new Operation_Vet()
                        {
                            OperationId = 3,
                            VetId = 1,
                        },
                        new Operation_Vet()
                        {
                            OperationId = 4,
                            VetId = 2,
                        },
                        new Operation_Vet()
                        {
                            OperationId = 4,
                            VetId = 1,
                        },
                        new Operation_Vet()
                        {
                            OperationId = 5,
                            VetId = 3,
                        },
                        new Operation_Vet()
                        {
                            OperationId = 5,
                            VetId = 2,
                        },
                        new Operation_Vet()
                        {
                            OperationId = 6,
                            VetId = 2,
                        },
                        new Operation_Vet()
                        {
                            OperationId = 6,
                            VetId = 1,
                        },



                    });
                    context.SaveChanges();

                    

                }
            }
        }
    }
}
