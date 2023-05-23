namespace Emerketo_webapp.Models
{
    public class MockProductRepository : IProductRepository
    {

        public IEnumerable<Product> AllProducts =>
            new List<Product>
            {
            #region NO CATEGORY
                new Product {
                    Id = 1,
                    Name = "Awesome Plant",
                    ShortDescription =  "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                        "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                        "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                    LongDescription =   "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                        "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                        "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                        "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                        "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                        "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                        "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                        "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                        "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                        "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                        "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                        "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                        "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                        "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                        "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                        "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                        "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                        "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                    NumOfReviews = 1,
                    Rating = 4.3M,
                    Price = 35.00M,
                    IsPopular = false,
                    IsNew = false,
                    IsFeatured = false,
                    ImgUrl = "/Images/Products/1.jpg"
                },
                new Product {
                    Id = 2,
                    Name = "Aquatic Plant",
                    ShortDescription =  "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                        "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                        "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                    LongDescription =   "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                        "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                        "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                        "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                        "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                        "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                        "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                        "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                        "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                        "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                        "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                        "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                        "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                        "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                        "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                        "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                        "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                        "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                    NumOfReviews = 25,
                    Rating = 3.5M,
                    Price = 27.00M,
                    IsPopular = false,
                    IsNew = false,
                    IsFeatured = false,
                    ImgUrl = "/Images/Products/2.jpg"
                },
                new Product {
                    Id = 3,
                    Name = "Aroma Plant",
                    ShortDescription =  "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                        "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                        "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                    LongDescription =   "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                        "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                        "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                        "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                        "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                        "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                        "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                        "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                        "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                        "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                        "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                        "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                        "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                        "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                        "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                        "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                        "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                        "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                    NumOfReviews = 12,
                    Rating = 4.1M,
                    Price = 45.00M,
                    IsPopular = false,
                    IsNew = false,
                    IsFeatured = false,
                    ImgUrl = "/Images/Products/3.jpg"
                },
                new Product {
                    Id = 4,
                    Name = "Aquatic Plant",
                    ShortDescription =  "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                        "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                        "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                    LongDescription =   "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                        "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                        "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                        "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                        "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                        "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                        "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                        "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                        "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                        "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                        "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                        "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                        "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                        "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                        "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                        "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                        "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                        "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                    NumOfReviews = 3,
                    Rating = 2.4M,
                    Price = 17.00M,
                    IsPopular = false,
                    IsNew = false,
                    IsFeatured = false,
                    ImgUrl = "/Images/Products/4.jpg"
                },
                new Product {
                    Id = 5,
                    Name = "Algea Plant",
                    ShortDescription =  "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                        "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                        "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                    LongDescription =   "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                        "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                        "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                        "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                        "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                        "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                        "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                        "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                        "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                        "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                        "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                        "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                        "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                        "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                        "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                        "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                        "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                        "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                    NumOfReviews = 35,
                    Rating = 4.9M,
                    Price = 30.00M,
                    IsPopular = false,
                    IsNew = false,
                    IsFeatured = false,
                    ImgUrl = "/Images/Products/5.jpg"
                },

                #endregion

                #region ONE CATEGORY
                new Product {
                Id = 6,
                Name = "Baccu Plant",
                ShortDescription =  "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                    "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                    "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                LongDescription =   "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                    "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                    "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                    "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                    "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                    "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                    "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                    "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                    "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                    "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                    "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                    "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                    "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                    "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                    "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                    "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                    "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                    "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                NumOfReviews = 35,
                Rating = 4.9M,
                Price = 30.00M,
                IsPopular = true,
                IsNew = false,
                IsFeatured = false,
                ImgUrl = "/Images/Products/6.jpg"
                },
                new Product {
                Id = 7,
                Name = "Baccu Plant",
                ShortDescription =  "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                    "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                    "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                LongDescription =   "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                    "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                    "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                    "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                    "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                    "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                    "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                    "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                    "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                    "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                    "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                    "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                    "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                    "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                    "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                    "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                    "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                    "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                NumOfReviews = 35,
                Rating = 4.9M,
                Price = 30.00M,
                IsPopular = false,
                IsNew = true,
                IsFeatured = false,
                ImgUrl = "/Images/Products/7.jpg"
                },
                new Product {
                    Id = 8,
                    Name = "Blossoming Plant",
                    ShortDescription =  "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                        "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                        "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                    LongDescription =   "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                        "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                        "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                        "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                        "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                        "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                        "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                        "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                        "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                        "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                        "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                        "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                        "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                        "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                        "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                        "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                        "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                        "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                    NumOfReviews = 12,
                    Rating = 4.1M,
                    Price = 45.00M,
                    IsPopular = false,
                    IsNew = false,
                    IsFeatured = true,
                    ImgUrl = "/Images/Products/8.jpg"
                },
                new Product {
                    Id = 9,
                    Name = "Beautiful Plant",
                    ShortDescription =  "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                        "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                        "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                    LongDescription =   "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                        "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                        "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                        "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                        "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                        "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                        "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                        "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                        "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                        "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                        "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                        "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                        "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                        "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                        "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                        "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                        "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                        "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                    NumOfReviews = 3,
                    Rating = 2.4M,
                    Price = 17.00M,
                    IsPopular = true,
                    IsNew = false,
                    IsFeatured = false,
                    ImgUrl = "/Images/Products/9.jpg"
                },
                new Product {
                    Id = 10,
                    Name = "Bright Plant",
                    ShortDescription =  "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                        "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                        "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                    LongDescription =   "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                        "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                        "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                        "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                        "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                        "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                        "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                        "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                        "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                        "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                        "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                        "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                        "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                        "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                        "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                        "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                        "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                        "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                    NumOfReviews = 35,
                    Rating = 4.9M,
                    Price = 30.00M,
                    IsPopular = false,
                    IsNew = true,
                    IsFeatured = false,
                    ImgUrl = "/Images/Products/10.jpg"
                },

                #endregion
                #region TWO CATEGORY
                new Product {
                    Id = 11,
                    Name = "Crooked Plant",
                    ShortDescription =  "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                        "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                        "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                    LongDescription =   "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                        "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                        "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                        "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                        "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                        "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                        "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                        "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                        "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                        "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                        "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                        "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                        "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                        "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                        "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                        "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                        "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                        "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                    NumOfReviews = 1,
                    Rating = 4.3M,
                    Price = 35.00M,
                    IsPopular = true,
                    IsNew = true,
                    IsFeatured = false,
                    ImgUrl = "/Images/Products/11.jpg"
                },
                new Product {
                    Id = 12,
                    Name = "Cavernous Plant",
                    ShortDescription =  "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                        "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                        "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                    LongDescription =   "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                        "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                        "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                        "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                        "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                        "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                        "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                        "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                        "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                        "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                        "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                        "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                        "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                        "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                        "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                        "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                        "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                        "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                    NumOfReviews = 25,
                    Rating = 3.5M,
                    Price = 27.00M,
                    IsPopular = true,
                    IsNew = false,
                    IsFeatured = true,
                    ImgUrl = "/Images/Products/12.jpg"
                },
                new Product {
                    Id = 13,
                    Name = "Cuddly Plant",
                    ShortDescription =  "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                        "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                        "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                    LongDescription =   "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                        "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                        "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                        "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                        "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                        "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                        "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                        "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                        "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                        "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                        "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                        "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                        "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                        "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                        "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                        "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                        "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                        "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                    NumOfReviews = 12,
                    Rating = 4.1M,
                    Price = 45.00M,
                    IsPopular = false,
                    IsNew = true,
                    IsFeatured = true,
                    ImgUrl = "/Images/Products/13.jpg"
                },
                new Product {
                    Id = 14,
                    Name = "Cabbage Plant",
                    ShortDescription =  "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                        "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                        "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                    LongDescription =   "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                        "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                        "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                        "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                        "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                        "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                        "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                        "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                        "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                        "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                        "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                        "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                        "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                        "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                        "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                        "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                        "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                        "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                    NumOfReviews = 3,
                    Rating = 2.4M,
                    Price = 17.00M,
                    IsPopular = true,
                    IsNew = false,
                    IsFeatured = true,
                    ImgUrl = "/Images/Products/14.jpg"
                },
                new Product {
                    Id = 15,
                    Name = "Darling Flower",
                    ShortDescription =  "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                        "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                        "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                    LongDescription =   "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                        "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                        "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                        "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                        "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                        "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                        "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                        "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                        "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                        "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                        "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                        "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                        "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                        "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                        "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                        "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                        "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                        "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                    NumOfReviews = 35,
                    Rating = 4.9M,
                    Price = 30.00M,
                    IsPopular = true,
                    IsNew = true,
                    IsFeatured = false,
                    ImgUrl = "/Images/Products/15.jpg"
                },

                #endregion
                #region THREE CATEGORIES
                new Product {
                    Id = 16,
                    Name = "Dear Flower",
                    ShortDescription =  "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                        "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                        "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                    LongDescription =   "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                        "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                        "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                        "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                        "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                        "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                        "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                        "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                        "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                        "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                        "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                        "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                        "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                        "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                        "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                        "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                        "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                        "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                    NumOfReviews = 35,
                    Rating = 4.9M,
                    Price = 30.00M,
                    IsPopular = true,
                    IsNew = true,
                    IsFeatured = true,
                    ImgUrl = "/Images/Products/16.jpg"
                },
                new Product {
                    Id = 17,
                    Name = "Decadent Plant",
                    ShortDescription =  "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                        "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                        "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                    LongDescription =   "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                        "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                        "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                        "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                        "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                        "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                        "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                        "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                        "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                        "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                        "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                        "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                        "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                        "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                        "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                        "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                        "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                        "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                    NumOfReviews = 35,
                    Rating = 4.9M,
                    Price = 30.00M,
                    IsPopular = true,
                    IsNew = true,
                    IsFeatured = true,
                    ImgUrl = "/Images/Products/17.jpg"
                },
                new Product {
                    Id = 18,
                    Name = "Dryair Plant",
                    ShortDescription =  "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                        "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                        "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                    LongDescription =   "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                        "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                        "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                        "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                        "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                        "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                        "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                        "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                        "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                        "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                        "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                        "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                        "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                        "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                        "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                        "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                        "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                        "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                    NumOfReviews = 35,
                    Rating = 4.9M,
                    Price = 30.00M,
                    IsPopular = true,
                    IsNew = true,
                    IsFeatured = true,
                    ImgUrl = "/Images/Products/18.jpg"
                },
                new Product {
                    Id = 19,
                    Name = "Doggy Flower",
                    ShortDescription =  "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                        "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                        "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                    LongDescription =   "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                        "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                        "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                        "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                        "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                        "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                        "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                        "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                        "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                        "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                        "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                        "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                        "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                        "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                        "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                        "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                        "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                        "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                    NumOfReviews = 35,
                    Rating = 4.9M,
                    Price = 30.00M,
                    IsPopular = true,
                    IsNew = true,
                    IsFeatured = true,
                    ImgUrl = "/Images/Products/19.jpg"
                },
                new Product {
                    Id = 20,
                    Name = "Domesticea Plant",
                    ShortDescription =  "Lorem ipsum dolor sit amet consectetur adipisicing elit. Repellendus aperiam " +
                                        "qui accusantium sapiente labore? Minima fuga omnis quos corporis veniam. Iste " +
                                        "accusantium reprehenderit, molestiae excepturi maiores corporis autem nobis voluptate.",
                    LongDescription =   "Lorem ipsum dolor sit amet consectetur adipisicing elit. Quod aliquid blanditiis " +
                                        "repellendus nam quos culpa, amet, eligendi quae impedit laborum dolore laudantium " +
                                        "tenetur. Repellendus debitis quia hic blanditiis, exercitationem quas veniam aliquid " +
                                        "possimus dicta totam, doloremque numquam, maxime dolorem.  Itaque ullam consequatur quae, " +
                                        "modi nulla sapiente placeat ipsum saepe libero odio labore porro sint rerum deserunt " +
                                        "minus praesentium velit distinctio enim officia! \nNecessitatibus, distinctio nobis? Eligendi," +
                                        "odio laborum quis sunt repellat nesciunt dolores a voluptates numquam quod accusamus " +
                                        "incidunt dolorum tempore iste unde deserunt earum harum illum vero. Amet earum fugiat, " +
                                        "sunt praesentium eveniet voluptatum. Exercitationem non cupiditate minima repellat " +
                                        "autem voluptates porro blanditiis vero ea sint excepturi dicta quis consectetur vel quod " +
                                        "pariatur dolore assumenda tempore esse, placeat commodi recusandae! Dolorem repellendus " +
                                        "delectus numquam tenetur, vero id ab amet eaque cum similique dolore autem corporis qui " +
                                        "voluptatem magnam tempore optio blanditiis iste quaerat praesentium eius dolores corrupti " +
                                        "error dolor. Quasi nobis officiis quod labore. Quis, ad tempora corporis dolores dignissimos, " +
                                        "reiciendis, quo soluta minima maxime aperiam quos at aliquam. \nOptio porro saepe earum, " +
                                        "temporibus ducimus quidem accusantium rem quisquam. Veritatis, harum ad. Doloribus " +
                                        "perspiciatisvoluptatibus ipsum necessitatibus sequi suscipit! Provident illo ea aliquam " +
                                        "voluptates dolores quia veritatis minus nemo eaque sunt? ",
                    NumOfReviews = 35,
                    Rating = 4.9M,
                    Price = 30.00M,
                    IsPopular = true,
                    IsNew = true,
                    IsFeatured = true,
                    ImgUrl = "/Images/Products/20.jpg"
                },
                #endregion
            };
        public IEnumerable<Product> NewProducts
        {
            get
            {
                return AllProducts.Where(p => p.IsNew == true);
            }
        }
        public IEnumerable<Product> PopularProducts
        {
            get
            {
                return AllProducts.Where(p => p.IsPopular == true);
            }
        }
        public IEnumerable<Product> FeaturedProducts
        {
            get
            {
                return AllProducts.Where(p => p.IsFeatured == true);
            }
        }
        public Product? GetProductById(int id) => AllProducts.FirstOrDefault(p => p.Id == id);
    }
}
