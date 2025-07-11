using eCommerce.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace eCommerce.Infrastructure.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // any guid
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            var customerId = new Guid("A4CC4BD7-64C7-4B4C-8DE8-924A35223ED0");

            modelBuilder.Entity<ApplicationRole>().HasData(
                new ApplicationRole
                {
                    Id = Guid.Parse("b1d7f736-9c9f-41f5-9179-9d3ce2a1c63a"),
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                },
                new ApplicationRole
                {
                    Id = Guid.Parse("f3c6e017-491f-4531-bdf4-60414e5a1c25"),
                    Name = "Customer",
                    NormalizedName = "CUSTOMER",
                    ConcurrencyStamp = Guid.NewGuid().ToString()
                }
            );

            var hasher = new PasswordHasher<ApplicationUser>();
            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "maileduong92@gmail.com",
                NormalizedEmail = "maileduong92@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admin@123"),
                SecurityStamp = string.Empty,
                FirstName = "Duong",
                LastName = "Mai",
                Dob = new DateTime(2020, 01, 31)
            });
            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = customerId,
                UserName = "customer",
                NormalizedUserName = "customer",
                Email = "customer@gmail.com",
                NormalizedEmail = "customer@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Customer@123"),
                SecurityStamp = string.Empty,
                FirstName = "Duong",
                LastName = "Mai",
                Dob = new DateTime(2020, 01, 31)
            });

            modelBuilder.Entity<ApplicationUserRole>().HasData(new ApplicationUserRole
            {
                RoleId = Guid.Parse("b1d7f736-9c9f-41f5-9179-9d3ce2a1c63a"),
                UserId = adminId
            });
            modelBuilder.Entity<ApplicationUserRole>().HasData(new ApplicationUserRole
            {
                RoleId = Guid.Parse("f3c6e017-491f-4531-bdf4-60414e5a1c25"),
                UserId = adminId
            });

            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 1, IsCarousel = true, Name = "Alexa Hampton", Slug = "the-alexa-hampton-collection", SortOrder = 10,  Description = "From New York City to Hangzhou, China, Alexa Hampton’s project portfolio encompasses luxe, beautifully layered urban apartments, expansive town and country residences, private airplanes, and yachts. Regularly named to Architectural Digest’s AD100 and House Beautiful’s Top Designer list as well as Elle Décor’s A-List, Hampton translates the classical principles of good design and decoration into some of today’s most elegant, enduring, and functional domestic landscapes." });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 2, IsCarousel = true, Name = "Althorp Living History", Slug = "althorp-living-history", SortOrder = 20, Description = "The Iconic Collection makes careful use of rich materials and elevated forms for a discerning aesthetic that emphasizes luxury and eclectic refinement. Bronze outlines, asymmetric surfaces, sumptuous tufting, and bold, textural bases are beautifully concluded in an Icon Bronze finish." });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 3, IsCarousel = true, Name = "Althorp - Victory Oak", Slug = "althorp--victory-oak", SortOrder = 30, Description = "The histories of the Spencer Family’s Heritage and Althorp are so tightly entwined that they would be impossible to unravel and separate. These Spencer ancestors were able to indulge their tastes – to commission art, furniture, and all the finer things in life. You can see the Spencer touch in every corner of Althorp – this historic house that my family has called “home” for over 500 years, and which for the past decade, has been given unprecedented care and attention." });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 4, IsCarousel = true, Name = "Balboa", Slug = "balboa", SortOrder = 40, Description = "A modern view of transitional luxe, Balboa creates an air of timeless elegance that blends seamlessly with today’s contemporary style. Simplistic forms and clean architectural lines, influenced by the works of George Hepplewhite, are paired with reeded carvings as a nod to the French Provincial aesthetic. Oak wood in a Coastal Grey finish is complemented with reeding and Dark Nickel." });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 5, IsCarousel = true, Name = "Breeze", Slug = "breeze-collection", SortOrder = 50, Description = "Organic modern forms are boldly reimagined in Breeze. Across the collection, a striking elegance is conveyed through faceted angles, beveled profiles, sunburst veneers, and unique Dark Sterling hardware. Using a handcrafted wire-brushed pine, each piece is then perfectly finished in a light and subdued Sea Salt. " });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 6, IsCarousel = true, Name = "Brooksby", Slug = "brooksby", SortOrder = 60, Description = "In the Brooksby Collection, classical forms enjoy a refined simplicity across hand-carved motifs, saber legs, and traditional European silhouettes. Beautifully crafted from mahogany and cerejeira veneer for a distinguished elegance. " });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 7, IsCarousel = false, Name = "Castle Bromwich", Slug = "castle-bromwich", SortOrder = 70, Description = "The Castle Bromwich collection exudes a polished sophistication in pieces that carefully reflect a classical influence. Gracefully showcasing the refined elegance of traditional forms, antiqued mahogany is exquisitely shaped with pedestal bases, turnings, and scroll carvings. " });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 8, IsCarousel = true, Name = "Catalina", Slug = "catalina", SortOrder = 80, Description = "Drawing inspiration from organic silhouettes and centered by the beauty of ash, a refined minimalism brings attention toward highly textural forms, rich grains, and porous stones. Perfectly hand-finished in a choice of Dune or Earth. " });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 9, IsCarousel = true, Name = "Dorchester", Slug = "dorchester", SortOrder = 90, Description = "The Dorchester Collection is an accomplished reimagining of early 20th century design. Pairing decorative ornamentation with masterfully sculpted forms, handcrafted silhouettes lend themselves to a refined and sumptuous presence across swooping curves, tapered lines, and modern profiles." });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 10, IsCarousel = true, Name = "Echoes", Slug = "the-echoes-collection", SortOrder = 100, Description = "The Echoes Collection is a material story of oak wood, intricate parquetry and hand-cast aluminum, plus distressed leather and Belgian linens with widely spaced nailhead to soften the look. Our specially calibrated industrial chic finishes are weathered and dry, but full of tactile appeal and vivacity." });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 11, IsCarousel = true, Name = "Essence", Slug = "essence-collection", SortOrder = 110, Description = "The Essence collection is composed from an alluring blend of rich materials and imaginative forms. Tasteful, softened lines are gracefully juxtaposed by organic shapes and highly textural silhouettes. Compellingly crafted from white oak and hand-finished in a choice of Blonde or Opal. " });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 12, IsCarousel = true, Name = "Horizon", Slug = "horizon", SortOrder = 120, Description = "The gracefully rounded forms of  the Horizon collection paired with  the fine reeded details of these oak  designs provide airy silhouettes that  are ideal for laid back contemporary  living. The Horizon collection is  offered in a light Day finish ensuring  a sleek finish, clean lines, versatility  and elegance to spare." });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 13, IsCarousel = true, Name = "Hudson", Slug = "hudson-collection", SortOrder = 130, Description = "Luxurious upholstered pieces pair elegantly with rich maple veneers and contrasting metal accents in Theodore Alexander’s Hudson Collection. A curated assortment of exquisite designs, the feeling of Art Deco luxury follows muted burl finished in exquisite maple grey with polished stainless-steel accents. From contrasting maple drawers to white marble tops, the Hudson Collection places an emphasis on sleek and modern sophistication. Finished in Pebble Grey with stainless steel hardware." });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 14, IsCarousel = false, Name = "Isola", Slug = "the-isola-collection", SortOrder = 140, Description = "Luxurious materials and unparalleled craftsmanship form a bold complexity in the Isola collection. Pieces enjoy a varied aesthetic that centers on geometric shapes in the form of chevron relief, nested squares, and asymmetrical patterns. Finished in a choice of Gowan or Charteris. " });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 15, IsCarousel = true, Name = "Judith Leiber Couture", Slug = "judith-leiber-couture", SortOrder = 150, Description = "Immerse yourself in the opulent world of Judith Leiber Couture with our inaugural collection, a showcase of indulgent sophistication that pays homage to the iconic aesthetic of the revered fashion designer. Each piece is a creative masterpiece, adorned with resplendent details such as mother-of-pearl encrusted inlays, meticulously hand-painted details, and polished brass accents. Presented in the exquisite Mink or Martini oak finishes, these luxurious statement pieces, mirroring the essence of the brand’s iconic handbags, are tailored to individuals who embrace an elegant approach to life." });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 16, IsCarousel = true, Name = "Kesden", Slug = "kesden-collection", SortOrder = 160, Description = "The Kesden Collection tells a story that begins with the depth and richness of Theodore Alexander’s veneers and ends with clean and transitional lines that promote gorgeous finishes and metal accents. The Kesden Collection possesses a feeling of effortless sophistication. With graceful silhouettes and gentle figures, Kesden is a harmonious blend of organic, sculpted bamboo forms and contrasting marbles, metals and veneers. From exquisite legs in bronze to Tamo ash burl tops, each piece serves as functional art for the home." });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 17, IsCarousel = true, Name = "LIDO", Slug = "lido-collection", SortOrder = 170, Description = "A modern view of transitional luxe, Lido creates an air of timeless elegance that blends seamlessly with today’s contemporary style. Simplistic forms and clean architectural lines, influenced by the works of George Hepplewhite, are paired with reeded carvings as a nod to the French Provincial aesthetic. Figured Prima Vera and Beech, featured in our dark Bistre finish, is complimented by a beautifully honed Crema Marfil marble stone top. Lido’s custom forged hardware adds an alluring air of sophistication in a dark rubbed bronze finish, echoing the reeding details throughout." });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 18, IsCarousel = true, Name = "Luna", Slug = "luna", SortOrder = 180, Description = "A tease between understated glamor  and coastal ease, the Luna collection’s  gentle round edges and stylish  silhouettes infuse contemporary comfort  in two colorways: dark Palmer and  light Cascade. This collection’s suite of  thoughtfully designed oak furnishings  adapts to a wide range of settings from  seaside estate to bustling city lofts and  everything in between." });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 19, IsCarousel = true, Name = "Maxwell", Slug = "maxwell", SortOrder = 190, Description = "Taking cues from sophistication of  simplicity, the Maxwell collection’s pared  down shapes make way for its textural  shagreen surfaces. Available in Obsidian  and Cashmere finishes, this handsome  collection of oak furnishings is versatile  and sculptural while delivering an elevated  and modern air to the spaces they inhabit." });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 20, IsCarousel = true, Name = "Montauk", Slug = "montauk", SortOrder = 200, Description = "The Montauk collection is a seamlessly  crafted ensemble of transitional  wooden case goods that effortlessly  blends contemporary design with  timeless elegance. The finishes  options enhance the organic appeal  of this offering, while the clean lines  and subtle detailing lend a modern  touch to the furniture. Available in  a bold Jetty and soft Lighthouse  colorway this collection’s chameleon  ability to morph between aesthetics  solidifies its heirloom qualities that will  stand the test of time." });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 21, IsCarousel = false, Name = "Morning Room", Slug = "morning-room", SortOrder = 210, Description = "Morning Room" });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 22, IsCarousel = true, Name = "NOVA", Slug = "nova-collection", SortOrder = 220, Description = "Refined and minimal, a feeling of subdued elegance surrounds the NOVA collection. Pleasing details of hand-carved starburst and herringbone parquetry, rustic oak, and verde bronzed hardware add to the quiet simplicity. Beautifully finished in a choice of Dawn or Dusk. " });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 23, IsCarousel = true, Name = "Origins", Slug = "origins", SortOrder = 230, Description = "Inspired by an appreciation of Art Deco and Streamline Moderne, the sketches of Paul Maitland-Smith are reimagined in Origins. Long, low profiles, limited ornamentation, and attenuated forms embody the spirit of the collection, while the pieces themselves offer a sense of forward movement that can be both seen and felt." });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 24, IsCarousel = true, Name = "Repose", Slug = "repose", SortOrder = 240, Description = "Elevated by a carefully sculpted minimalism, the Repose collection beautifully plays sinuous curves against distinctly shaped forms in a relaxed palette of soothing neutrals. Wire-brushed white oak is elegantly finished in a choice of Charcoal Oak or Grey Oak. " });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 25, IsCarousel = true, Name = "Rome", Slug = "rome", SortOrder = 250, Description = "The Rome collection is expanded  beyond tables this spring,  translating its organic, slender  framework into wood. The warmth  of the oak paired with graceful  curves creates sculptural pieces that  are offered in a rich Nera finish." });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 26, IsCarousel = true, Name = "Seated", Slug = "seated", SortOrder = 260, Description = "Seated" });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 27, IsCarousel = true, Name = "Sloane", Slug = "sloane", SortOrder = 270, Description = "A contemporary reinterpretation of designs from the 18th and 19th centuries, the Sloane Collection is a refined homage to the American Federal era and its English influences. Artisanal craftsmanship brings to life the balanced forms and pleasing silhouettes, while resplendent materials elegantly complete the pieces." });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 28, IsCarousel = true, Name = "Spencer London", Slug = "spencer-london", SortOrder = 280, Description = "Marrying styles of Lord Spencer’s London home  with the exquisite capabilities of Theodore  Alexander’s craftsmanship, the Spencer London  collection brings fresh perspective to elegant  metro living. A consistent thread of chic,  mixed metal inlays are seen throughout the  furniture forms, bringing England’s rich history  to a current day contemporary style. Crafted  in figured sycamore, maple, and khaya crotch  wood, these designs have been painstakingly  fine tuned to offer a tailored product that is  uncompromising, timeless and approachable." });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 29, IsCarousel = true, Name = "Spencer ST. James", Slug = "spencer-st-james", SortOrder = 290, Description = "A striking capsule collection, Spencer St. James is made of oak and adorned with crocodile-embossed leather, creating textural, statement-making experiences within the home. Available in a light Argento finish or a dark Onyx finish, the Spencer St. James collection blends contemporary flair with exquisite creativity and luxury details. These focal points elevate modern living spaces, whether hosting guests around sleek occasional tables or pouring spirits from its low-profile bar that has a colorful element of surprise inside." });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 30, IsCarousel = true, Name = "Stephen Church", Slug = "the-stephen-church-collection", SortOrder = 300, Description = "Stephen Church is a Master Cabinetmaker who designs as well as crafts fine furniture following the tradition of English 18th century cabinet makers from Adam and Chippendale to Hepplewhite and Sheraton. Today those traditions are maintained with pride by a selected team of craftsmen working at Theodore Alexander." });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 31, IsCarousel = true, Name = "Surrey", Slug = "surrey", SortOrder = 310, Description = "The Iconic Collection makes careful use of rich materials and elevated forms for a discerning aesthetic that emphasizes luxury and eclectic refinement. Bronze outlines, asymmetric surfaces, sumptuous tufting, and bold, textural bases are beautifully concluded in an Icon Bronze finish." });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 32, IsCarousel = false, Name = "TA Artistry", Slug = "ta-artistry", SortOrder = 320, Description = "TA Artistry" });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 33, IsCarousel = true, Name = "TA Originals", Slug = "ta-originals", SortOrder = 330, Description = "Rich, one-of-a-kind forms handcrafted in the finest materials and finishes. The TA Originals Collection brings artistic visions to life." });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 34, IsCarousel = true, Name = "TA Studio", Slug = "ta-studio", SortOrder = 340, Description = "TA Studio is an elegant, highly polished presentation of luxurious forms. Rich details of metallic accents, embossed shagreen leather wrappings, and superb finishes offer a sense of refinement atop designs composed from crisp angles, soft curves, and tapered silhouettes. " });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 35, IsCarousel = true, Name = "Tavel", Slug = "the-tavel-collection", SortOrder = 350, Description = "Inspired by the “Golden Age” of French Decorative Art, the Tavel collection gracefully echoes the intricate details and masterful craftsmanship of the late 18th century. Hand-carved motifs, saber legs, molded cornices, and serpentine drawers are exquisitely formed from beech, walnut, and oak woods. Finished in a refined selection of Avesta, Nora, and Elsa." });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 36, IsCarousel = true, Name = "Upholstery", Slug = "upholstery", SortOrder = 360, Description = "The Theodore Alexander brand is synonymous with innovative designs that speak to today's lifestyles in ways that excite and entice. Theodore Alexander Upholstery is created with uncompromising standards and attention to detail." });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 37, IsCarousel = true, Name = "Accessories", Slug = "accessories", SortOrder = 370, Description = "Introducing a symphony of form and function that  harmoniously blends diverse materials to elevate your  living spaces. From elegant bookends to captivating  sculptures, each piece in this collection is meticulously  crafted to enhance your home decor." });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 38, IsCarousel = true, Name = "Urbane", Slug = "urbane", SortOrder = 380, Description = "Embracing a contemporary, casual aesthetic, the Urbane collection is a fashion forward collection made of wire-brushed pine. The legs are designed to create an eye-catching floating appearance, while its long, slender hardware is inspired by the texture of lizard skin. The Urbane collection debuts in two refined finishes: Campfire and Sundew. From bedrooms to dining rooms, each piece delivers a minimalist charm and artisanal warmth." });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 39, IsCarousel = true, Name = "Art by TA", Slug = "art-by-ta", SortOrder = 390, Description = "Introducing ART by TA, an exclusive collection of unique, curated wall art that adds a finishing touch to every space." });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 40, IsCarousel = true, Name = "TA Illuminations", Slug = "ta-illuminations", SortOrder = 400, Description = "Introducing the “TA Illuminations” Lighting Collection by  Theodore Alexander – where artistry meets illumination.  This curated collection celebrates the interplay of  materials, styles, and sizes, creating a symphony of light  that transforms any space into a captivating haven." });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 41, IsCarousel = true, Name = "Floored", Slug = "floored", SortOrder = 410, Description = "Defying style boundaries, the Floored Collection encompasses our carefully curated portfolio of designs, offerings rugs with a variety of dimensions to fit the aesthetic of any room.</br>Choosing a hand-woven or hand-knotted rug within our Stocked Collection allows for fulfillment along a convenient quick-ship timeline, perfect for projects with tight turnaround times. Love a Stocked design but need a custom size? Pieces within Floored’s Stocked program can also be crafted to suit alternative sizing requirements, extending the production timeline but offering the same gorgeous designs to perfectly fit unique spaces.</br>Bespoke spaces often call for custom-tailored floor coverings, and Floored’s Custom Collection provides solutions for rooms requiring that personal touch. Floored’s Custom Rugs are hand tufted and hand woven with Axminster and Hand Loomed constructions, offering an extensive assortment of options for color, pattern, style, sizing and more." });
            modelBuilder.Entity<Collection>().HasData(new Collection { Id = 42, IsCarousel = true, Name = "THEO by Theodore Alexander", Slug = "theo-by-theodore-alexander", SortOrder = 420, Description = "THEO by Theodore Alexander" });

            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 1, CollectionId = 1, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-alexa-hampton-collection/1.jpg", SortOrder = 10, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 2, CollectionId = 1, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-alexa-hampton-collection/2.jpg", SortOrder = 20, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 3, CollectionId = 1, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-alexa-hampton-collection/3.jpg", SortOrder = 30, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 4, CollectionId = 1, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-alexa-hampton-collection/4.jpg", SortOrder = 40, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 5, CollectionId = 1, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-alexa-hampton-collection/5.jpg", SortOrder = 50, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 6, CollectionId = 1, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-alexa-hampton-collection/6.jpg", SortOrder = 60, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 7, CollectionId = 1, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-alexa-hampton-collection/7.jpg", SortOrder = 70, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 8, CollectionId = 1, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-alexa-hampton-collection/8.jpg", SortOrder = 80, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 9, CollectionId = 1, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-alexa-hampton-collection/9.jpg", SortOrder = 90, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 10, CollectionId = 1, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-alexa-hampton-collection/10.jpg", SortOrder = 100, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 11, CollectionId = 1, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-alexa-hampton-collection/11.jpg", SortOrder = 110, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 12, CollectionId = 1, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-alexa-hampton-collection/12.jpg", SortOrder = 120, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 13, CollectionId = 1, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-alexa-hampton-collection/13.jpg", SortOrder = 130, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 14, CollectionId = 1, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-alexa-hampton-collection/14.jpg", SortOrder = 140, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 15, CollectionId = 1, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-alexa-hampton-collection/15.jpg", SortOrder = 150, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 16, CollectionId = 1, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-alexa-hampton-collection/16.jpg", SortOrder = 160, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 17, CollectionId = 1, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-alexa-hampton-collection/17.jpg", SortOrder = 170, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 18, CollectionId = 1, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-alexa-hampton-collection/18.jpg", SortOrder = 180, ImageType = 0 });

            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 19, CollectionId = 2, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp-living-history/1.jpg", SortOrder = 10, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 20, CollectionId = 2, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp-living-history/2.jpg", SortOrder = 20, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 21, CollectionId = 2, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp-living-history/3.jpg", SortOrder = 30, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 22, CollectionId = 2, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp-living-history/4.jpg", SortOrder = 40, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 23, CollectionId = 2, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp-living-history/5.jpg", SortOrder = 50, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 24, CollectionId = 2, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp-living-history/6.jpg", SortOrder = 60, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 25, CollectionId = 2, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp-living-history/7.jpg", SortOrder = 70, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 26, CollectionId = 2, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp-living-history/8.jpg", SortOrder = 80, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 27, CollectionId = 2, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp-living-history/9.jpg", SortOrder = 90, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 28, CollectionId = 2, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp-living-history/10.jpg", SortOrder = 100, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 29, CollectionId = 2, ImageUrl = "https://theodorealexander.sirv.com/Videos/Althorp%20for%20website_Collection%20banner_with_captions.mp4", SortOrder = 110, ImageType = 1 });

            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 30, CollectionId = 3, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp--victory-oak/1.jpg", SortOrder = 10, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 31, CollectionId = 3, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp--victory-oak/2.jpg", SortOrder = 20, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 32, CollectionId = 3, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp--victory-oak/3.jpg", SortOrder = 30, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 33, CollectionId = 3, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp--victory-oak/4.jpg", SortOrder = 40, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 34, CollectionId = 3, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp--victory-oak/5.jpg", SortOrder = 50, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 35, CollectionId = 3, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp--victory-oak/6.jpg", SortOrder = 60, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 36, CollectionId = 3, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp--victory-oak/7.jpg", SortOrder = 70, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 37, CollectionId = 3, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp--victory-oak/8.jpg", SortOrder = 80, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 38, CollectionId = 3, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp--victory-oak/9.jpg", SortOrder = 90, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 39, CollectionId = 3, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/althorp--victory-oak/10.jpg", SortOrder = 100, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 40, CollectionId = 3, ImageUrl = "https://theodorealexander.sirv.com/Videos/Althorp%20for%20website_Collection%20banner_with_captions.mp4", SortOrder = 110, ImageType = 1 });

            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 41, CollectionId = 4, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/balboa/1.jpg", SortOrder = 10, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 42, CollectionId = 4, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/balboa/2.jpg", SortOrder = 20, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 43, CollectionId = 4, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/balboa/3.jpg", SortOrder = 30, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 44, CollectionId = 4, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/balboa/4.jpg", SortOrder = 40, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 45, CollectionId = 4, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/balboa/5.jpg", SortOrder = 50, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 46, CollectionId = 4, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/balboa/6.jpg", SortOrder = 60, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 47, CollectionId = 4, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/balboa/7.jpg", SortOrder = 70, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 48, CollectionId = 4, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/balboa/8.jpg", SortOrder = 80, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 49, CollectionId = 4, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/balboa/9.jpg", SortOrder = 90, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 50, CollectionId = 4, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/balboa/10.jpg", SortOrder = 100, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 51, CollectionId = 4, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/balboa/11.jpg", SortOrder = 110, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 52, CollectionId = 4, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/balboa/12.jpg", SortOrder = 120, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 53, CollectionId = 4, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/balboa/13.jpg", SortOrder = 130, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 54, CollectionId = 4, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/balboa/14.jpg", SortOrder = 140, ImageType = 0 });

            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 55, CollectionId = 5, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/breeze-collection/1.jpg", SortOrder = 10, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 56, CollectionId = 5, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/breeze-collection/2.jpg", SortOrder = 20, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 57, CollectionId = 5, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/breeze-collection/3.jpg", SortOrder = 30, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 58, CollectionId = 5, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/breeze-collection/4.jpg", SortOrder = 40, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 59, CollectionId = 5, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/breeze-collection/5.jpg", SortOrder = 50, ImageType = 0 });

            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 60, CollectionId = 6, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/brooksby/1.jpg", SortOrder = 10, ImageType = 0 });

            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 61, CollectionId = 8, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/catalina/1.jpg", SortOrder = 10, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 62, CollectionId = 8, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/catalina/2.jpg", SortOrder = 20, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 63, CollectionId = 8, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/catalina/3.jpg", SortOrder = 30, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 64, CollectionId = 8, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/catalina/4.jpg", SortOrder = 40, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 65, CollectionId = 8, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/catalina/5.jpg", SortOrder = 50, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 66, CollectionId = 8, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/catalina/6.jpg", SortOrder = 60, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 67, CollectionId = 8, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/catalina/7.jpg", SortOrder = 70, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 68, CollectionId = 8, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/catalina/8.jpg", SortOrder = 80, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 69, CollectionId = 8, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/catalina/9.jpg", SortOrder = 90, ImageType = 0 });

            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 70, CollectionId = 9, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/dorchester/1.jpg", SortOrder = 10, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 71, CollectionId = 9, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/dorchester/2.jpg", SortOrder = 20, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 72, CollectionId = 9, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/dorchester/3.jpg", SortOrder = 30, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 73, CollectionId = 9, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/dorchester/4.jpg", SortOrder = 40, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 74, CollectionId = 9, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/dorchester/5.jpg", SortOrder = 50, ImageType = 0 });

            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 75, CollectionId = 10, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-echoes-collection/1.jpg", SortOrder = 10, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 76, CollectionId = 10, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-echoes-collection/2.jpg", SortOrder = 20, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 77, CollectionId = 10, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-echoes-collection/3.jpg", SortOrder = 30, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 78, CollectionId = 10, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-echoes-collection/4.jpg", SortOrder = 40, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 79, CollectionId = 10, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-echoes-collection/5.jpg", SortOrder = 50, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 80, CollectionId = 10, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-echoes-collection/6.jpg", SortOrder = 60, ImageType = 0 });

            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 81, CollectionId = 11, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/essence-collection/1.jpg", SortOrder = 10, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 82, CollectionId = 11, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/essence-collection/2.jpg", SortOrder = 20, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 83, CollectionId = 11, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/essence-collection/3.jpg", SortOrder = 30, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 84, CollectionId = 11, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/essence-collection/4.jpg", SortOrder = 40, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 85, CollectionId = 11, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/essence-collection/5.jpg", SortOrder = 50, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 86, CollectionId = 11, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/essence-collection/6.jpg", SortOrder = 60, ImageType = 0 });

            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 87, CollectionId = 12, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/horizon/1.jpg", SortOrder = 10, ImageType = 0 });

            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 88, CollectionId = 13, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/hudson-collection/1.jpg", SortOrder = 10, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 89, CollectionId = 13, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/hudson-collection/2.jpg", SortOrder = 20, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 90, CollectionId = 13, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/hudson-collection/3.jpg", SortOrder = 30, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 91, CollectionId = 13, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/hudson-collection/4.jpg", SortOrder = 40, ImageType = 0 });

            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 92, CollectionId = 15, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/judith-leiber-couture/1.jpg", SortOrder = 10, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 93, CollectionId = 15, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/judith-leiber-couture/2.jpg", SortOrder = 20, ImageType = 0 });

            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 94, CollectionId = 16, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/kesden-collection/1.jpg", SortOrder = 10, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 95, CollectionId = 16, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/kesden-collection/2.jpg", SortOrder = 20, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 96, CollectionId = 16, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/kesden-collection/3.jpg", SortOrder = 30, ImageType = 0 });

            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 97, CollectionId = 17, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/lido-collection/1.jpg", SortOrder = 10, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 98, CollectionId = 17, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/lido-collection/2.jpg", SortOrder = 20, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 99, CollectionId = 17, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/lido-collection/3.jpg", SortOrder = 30, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 100, CollectionId = 17, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/lido-collection/4.jpg", SortOrder = 40, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 101, CollectionId = 17, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/lido-collection/5.jpg", SortOrder = 50, ImageType = 0 });

            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 102, CollectionId = 18, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/luna/1.jpg", SortOrder = 10, ImageType = 0 });

            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 103, CollectionId = 19, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/maxwell/1.jpg", SortOrder = 10, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 104, CollectionId = 19, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/maxwell/2.jpg", SortOrder = 20, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 105, CollectionId = 19, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/maxwell/3.jpg", SortOrder = 30, ImageType = 0 });

            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 106, CollectionId = 20, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/montauk/1.jpg", SortOrder = 10, ImageType = 0 });

            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 107, CollectionId = 22, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/nova-collection/1.jpg", SortOrder = 10, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 108, CollectionId = 22, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/nova-collection/2.jpg", SortOrder = 20, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 109, CollectionId = 22, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/nova-collection/3.jpg", SortOrder = 30, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 110, CollectionId = 22, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/nova-collection/4.jpg", SortOrder = 40, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 111, CollectionId = 22, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/nova-collection/5.jpg", SortOrder = 50, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 112, CollectionId = 22, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/nova-collection/6.jpg", SortOrder = 60, ImageType = 0 });

            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 113, CollectionId = 23, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/origins/1.jpg", SortOrder = 10, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 114, CollectionId = 23, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/origins/2.jpg", SortOrder = 20, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 115, CollectionId = 23, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/origins/3.jpg", SortOrder = 30, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 116, CollectionId = 23, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/origins/4.jpg", SortOrder = 40, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 117, CollectionId = 23, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/origins/5.jpg", SortOrder = 50, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 118, CollectionId = 23, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/origins/6.jpg", SortOrder = 60, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 119, CollectionId = 23, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/origins/7.jpg", SortOrder = 70, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 120, CollectionId = 23, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/origins/8.jpg", SortOrder = 80, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 121, CollectionId = 23, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/origins/9.jpg", SortOrder = 90, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 122, CollectionId = 23, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/origins/10.jpg", SortOrder = 100, ImageType = 0 });

            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 123, CollectionId = 24, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/repose/1.jpg", SortOrder = 10, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 124, CollectionId = 24, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/repose/2.jpg", SortOrder = 20, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 125, CollectionId = 24, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/repose/3.jpg", SortOrder = 30, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 126, CollectionId = 24, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/repose/4.jpg", SortOrder = 40, ImageType = 0 });

            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 127, CollectionId = 25, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/rome/1.jpg", SortOrder = 10, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 128, CollectionId = 25, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/rome/2.jpg", SortOrder = 20, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 129, CollectionId = 25, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/rome/3.jpg", SortOrder = 30, ImageType = 0 });

            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 130, CollectionId = 27, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/sloane/1.jpg", SortOrder = 10, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 131, CollectionId = 27, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/sloane/2.jpg", SortOrder = 20, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 132, CollectionId = 27, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/sloane/3.jpg", SortOrder = 30, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 133, CollectionId = 27, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/sloane/4.jpg", SortOrder = 40, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 134, CollectionId = 27, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/sloane/5.jpg", SortOrder = 50, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 135, CollectionId = 27, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/sloane/6.jpg", SortOrder = 60, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 136, CollectionId = 27, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/sloane/7.jpg", SortOrder = 70, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 137, CollectionId = 27, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/sloane/8.jpg", SortOrder = 80, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 138, CollectionId = 27, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/sloane/9.jpg", SortOrder = 90, ImageType = 0 });

            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 139, CollectionId = 28, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/spencer-london/1.jpg", SortOrder = 10, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 140, CollectionId = 28, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/spencer-london/2.jpg", SortOrder = 20, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 141, CollectionId = 28, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/spencer-london/3.jpg", SortOrder = 30, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 142, CollectionId = 28, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/spencer-london/4.jpg", SortOrder = 40, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 143, CollectionId = 28, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/spencer-london/5.jpg", SortOrder = 50, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 144, CollectionId = 28, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/spencer-london/6.jpg", SortOrder = 60, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 145, CollectionId = 28, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/spencer-london/7.jpg", SortOrder = 70, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 146, CollectionId = 28, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/spencer-london/8.jpg", SortOrder = 80, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 147, CollectionId = 28, ImageUrl = "https://theodorealexander.sirv.com/Videos/spencer.mp4", SortOrder = 1, ImageType = 1 });

            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 148, CollectionId = 29, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/spencer-st-james/1.jpg", SortOrder = 10, ImageType = 0 });

            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 149, CollectionId = 30, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-stephen-church-collection/1.jpg", SortOrder = 10, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 150, CollectionId = 30, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-stephen-church-collection/2.jpg", SortOrder = 20, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 151, CollectionId = 30, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-stephen-church-collection/3.jpg", SortOrder = 30, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 152, CollectionId = 30, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-stephen-church-collection/4.jpg", SortOrder = 40, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 153, CollectionId = 30, ImageUrl = "https://theodorealexander.sirv.com/Videos/Stephen_Church_with_caption.mp4", SortOrder = 1, ImageType = 1 });

            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 154, CollectionId = 31, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/surrey/1.jpg", SortOrder = 10, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 155, CollectionId = 31, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/surrey/2.jpg", SortOrder = 20, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 156, CollectionId = 31, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/surrey/3.jpg", SortOrder = 30, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 157, CollectionId = 31, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/surrey/4.jpg", SortOrder = 40, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 158, CollectionId = 31, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/surrey/5.jpg", SortOrder = 50, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 159, CollectionId = 31, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/surrey/6.jpg", SortOrder = 60, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 160, CollectionId = 31, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/surrey/7.jpg", SortOrder = 70, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 161, CollectionId = 31, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/surrey/8.jpg", SortOrder = 80, ImageType = 0 });

            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 162, CollectionId = 33, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/ta-originals/1.jpg", SortOrder = 10, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 163, CollectionId = 33, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/ta-originals/2.jpg", SortOrder = 20, ImageType = 0 });

            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 164, CollectionId = 34, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/ta-studio/1.jpg", SortOrder = 10, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 165, CollectionId = 34, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/ta-studio/2.jpg", SortOrder = 20, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 166, CollectionId = 34, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/ta-studio/3.jpg", SortOrder = 30, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 167, CollectionId = 34, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/ta-studio/4.jpg", SortOrder = 40, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 168, CollectionId = 34, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/ta-studio/5.jpg", SortOrder = 50, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 169, CollectionId = 34, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/ta-studio/6.jpg", SortOrder = 60, ImageType = 0 });

            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 170, CollectionId = 35, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-tavel-collection/1.jpg", SortOrder = 10, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 171, CollectionId = 35, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-tavel-collection/2.jpg", SortOrder = 20, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 172, CollectionId = 35, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/the-tavel-collection/3.jpg", SortOrder = 30, ImageType = 0 });

            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 173, CollectionId = 36, ImageUrl = "https://theodorealexander.sirv.com/Videos/TA_Upholstery_Factory_120423_1080p_Final_Lowres.mp4", SortOrder = 10, ImageType = 1 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 174, CollectionId = 36, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/upholstery/1.jpg", SortOrder = 20, ImageType = 0 });

            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 175, CollectionId = 37, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/accessories/1.jpg", SortOrder = 10, ImageType = 0 });

            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 176, CollectionId = 38, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/urbane/1.jpg", SortOrder = 10, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 177, CollectionId = 38, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/urbane/2.jpg", SortOrder = 20, ImageType = 0 });

            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 178, CollectionId = 39, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/art-by-ta/1.jpg", SortOrder = 10, ImageType = 0 });

            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 179, CollectionId = 40, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/ta-illuminations/1.jpg", SortOrder = 10, ImageType = 0 });
            modelBuilder.Entity<CollectionImage>().HasData(new CollectionImage { Id = 180, CollectionId = 40, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Collection/ta-illuminations/2.jpg", SortOrder = 20, ImageType = 0 });

            modelBuilder.Entity<Room>().HasData(new Room { Id = 1, Name = "Living", Slug = "living-room", SortOrder = 10, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Room/living-room/1.jpg", Description = "living" });
            modelBuilder.Entity<Room>().HasData(new Room { Id = 2, Name = "Dining", Slug = "dining-room", SortOrder = 20, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Room/dining-room/1.jpg", Description = "dining" });
            modelBuilder.Entity<Room>().HasData(new Room { Id = 3, Name = "Bed", Slug = "bedroom", SortOrder = 30, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Room/bedroom/1.jpg", Description = "bedroom" });
            modelBuilder.Entity<Room>().HasData(new Room { Id = 4, Name = "Office", Slug = "office", SortOrder = 40, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Room/office/1.jpg", Description = "office" });
            modelBuilder.Entity<Room>().HasData(new Room { Id = 5, Name = "Lighting", Slug = "lighting", SortOrder = 50, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Room/lighting/1.jpg", Description = "lighting" });
            modelBuilder.Entity<Room>().HasData(new Room { Id = 6, Name = "Décor", Slug = "decor", SortOrder = 60, ImageUrl = "https://ik.imagekit.io/9float9hy/Banner_for_Room/decor/1.jpg", Description = "decor" });

            modelBuilder.Entity<LifeStyle>().HasData(new LifeStyle { Id = 1, Name = "Classic", Slug = "classic", SortOrder = 10, ImageUrl = "", Description = "" });
            modelBuilder.Entity<LifeStyle>().HasData(new LifeStyle { Id = 2, Name = "Transitional", Slug = "transitional", SortOrder = 20, ImageUrl = "", Description = "" });
            modelBuilder.Entity<LifeStyle>().HasData(new LifeStyle { Id = 3, Name = "Rustic", Slug = "rustic", SortOrder = 30, ImageUrl = "", Description = "" });
            modelBuilder.Entity<LifeStyle>().HasData(new LifeStyle { Id = 4, Name = "Modern", Slug = "modern", SortOrder = 40, ImageUrl = "", Description = "" });
            modelBuilder.Entity<LifeStyle>().HasData(new LifeStyle { Id = 5, Name = "Casual", Slug = "casual", SortOrder = 50, ImageUrl = "", Description = "" });

            modelBuilder.Entity<Style>().HasData(new Style { Id = 1, Name = "Formal Classic", Slug = "classic", SortOrder = 10, ImageUrl = "", Description = "" });
            modelBuilder.Entity<Style>().HasData(new Style { Id = 2, Name = "Casual Classic", Slug = "casual-classic", SortOrder = 20, ImageUrl = "", Description = "" });
            modelBuilder.Entity<Style>().HasData(new Style { Id = 3, Name = "Formal Transitional", Slug = "formal-transitional", SortOrder = 30, ImageUrl = "", Description = "" });
            modelBuilder.Entity<Style>().HasData(new Style { Id = 4, Name = "Formal Traditional", Slug = "formal-traditional", SortOrder = 40, ImageUrl = "", Description = "" });
            modelBuilder.Entity<Style>().HasData(new Style { Id = 5, Name = "Casual Transitional", Slug = "casual-transitional", SortOrder = 50, ImageUrl = "", Description = "" });
            modelBuilder.Entity<Style>().HasData(new Style { Id = 6, Name = "Casual Traditional", Slug = "casual-traditional", SortOrder = 60, ImageUrl = "", Description = "" });
            modelBuilder.Entity<Style>().HasData(new Style { Id = 7, Name = "Casual Rustic", Slug = "casual-rustic", SortOrder = 70, ImageUrl = "", Description = "" });
            modelBuilder.Entity<Style>().HasData(new Style { Id = 8, Name = "Formal Modern", Slug = "formal-modern", SortOrder = 80, ImageUrl = "", Description = "" });
            modelBuilder.Entity<Style>().HasData(new Style { Id = 9, Name = "Casual Modern", Slug = "casual-modern", SortOrder = 90, ImageUrl = "", Description = "" });
            modelBuilder.Entity<Style>().HasData(new Style { Id = 10, Name = "Formal Casual", Slug = "formal-casual", SortOrder = 100, ImageUrl = "", Description = "" });
            modelBuilder.Entity<Style>().HasData(new Style { Id = 11, Name = "Casual", Slug = "casual", SortOrder = 110, ImageUrl = "", Description = "" });

            modelBuilder.Entity<ProductType>().HasData(new ProductType { Id = 1, RoomId = 1, Name = "Bookcases & Etageres", Slug = "bookcases--etageres", SortOrder = 100, ImageUrl = "", Description = "" });
            modelBuilder.Entity<ProductType>().HasData(new ProductType { Id = 2, RoomId = 1, Name = "Desks & Bureauxs", Slug = "Desks--Bureauxs", SortOrder = 200, ImageUrl = "", Description = "" });
            modelBuilder.Entity<ProductType>().HasData(new ProductType { Id = 3, RoomId = 1, Name = "Desk Chairs", Slug = "desk-chairs", SortOrder = 300, ImageUrl = "", Description = "" });
            modelBuilder.Entity<ProductType>().HasData(new ProductType { Id = 4, RoomId = 2, Name = "Round Dining Tables", Slug = "round-dining-tables", SortOrder = 400, ImageUrl = "", Description = "" });
            modelBuilder.Entity<ProductType>().HasData(new ProductType { Id = 5, RoomId = 2, Name = "Rectangular & Oval Dining Table", Slug = "rectangular--oval-dining-table", SortOrder = 500, ImageUrl = "", Description = "" });
            modelBuilder.Entity<ProductType>().HasData(new ProductType { Id = 6, RoomId = 2, Name = "Bar Carts & Cabinets", Slug = "bar-carts--cabinets", SortOrder = 600, ImageUrl = "", Description = "" });
            modelBuilder.Entity<ProductType>().HasData(new ProductType { Id = 7, RoomId = 2, Name = "Bar & Counter Stools", Slug = "bar--counter-stools", SortOrder = 700, ImageUrl = "", Description = "" });
            modelBuilder.Entity<ProductType>().HasData(new ProductType { Id = 8, RoomId = 2, Name = "Bar & Pub Tables", Slug = "bar--pub-tables", SortOrder = 800, ImageUrl = "", Description = "" });
            modelBuilder.Entity<ProductType>().HasData(new ProductType { Id = 9, RoomId = 2, Name = "China & Curio Cabinets", Slug = "china--curio-cabinets", SortOrder = 900, ImageUrl = "", Description = "" });
            modelBuilder.Entity<ProductType>().HasData(new ProductType { Id = 10, RoomId = 2, Name = "Dining Chairs", Slug = "dining-chairs", SortOrder = 1000, ImageUrl = "", Description = "" });
            modelBuilder.Entity<ProductType>().HasData(new ProductType { Id = 11, RoomId = 2, Name = "Sideboards & Buffets", Slug = "sideboards--buffets", SortOrder = 1100, ImageUrl = "", Description = "" });
            modelBuilder.Entity<ProductType>().HasData(new ProductType { Id = 12, RoomId = 3, Name = "Free Standing Accessories", Slug = "free-standing-accessories", SortOrder = 1200, ImageUrl = "", Description = "" });
            modelBuilder.Entity<ProductType>().HasData(new ProductType { Id = 13, RoomId = 3, Name = "Mirrors", Slug = "mirrors", SortOrder = 1300, ImageUrl = "", Description = "" });
            modelBuilder.Entity<ProductType>().HasData(new ProductType { Id = 14, RoomId = 3, Name = "Table Top Accessories", Slug = "table-top-accessories", SortOrder = 1400, ImageUrl = "", Description = "" });
            modelBuilder.Entity<ProductType>().HasData(new ProductType { Id = 15, RoomId = 3, Name = "Wall Art", Slug = "wall-art", SortOrder = 1500, ImageUrl = "", Description = "" });
            modelBuilder.Entity<ProductType>().HasData(new ProductType { Id = 16, RoomId = 4, Name = "Ceiling Lighting", Slug = "ceiling-lighting", SortOrder = 1600, ImageUrl = "", Description = "" });
            modelBuilder.Entity<ProductType>().HasData(new ProductType { Id = 17, RoomId = 4, Name = "Floor Lighting", Slug = "floor-lighting", SortOrder = 1700, ImageUrl = "", Description = "" });
            modelBuilder.Entity<ProductType>().HasData(new ProductType { Id = 18, RoomId = 4, Name = "Table Lighting", Slug = "table-lighting", SortOrder = 1800, ImageUrl = "", Description = "" });
            modelBuilder.Entity<ProductType>().HasData(new ProductType { Id = 19, RoomId = 5, Name = "Storage", Slug = "storage", SortOrder = 1900, ImageUrl = "", Description = "" });
            modelBuilder.Entity<ProductType>().HasData(new ProductType { Id = 20, RoomId = 5, Name = "Beds", Slug = "beds", SortOrder = 2000, ImageUrl = "", Description = "" });
            modelBuilder.Entity<ProductType>().HasData(new ProductType { Id = 21, RoomId = 5, Name = "Benches", Slug = "benches", SortOrder = 2100, ImageUrl = "", Description = "" });
            modelBuilder.Entity<ProductType>().HasData(new ProductType { Id = 22, RoomId = 5, Name = "Dressers & Chests", Slug = "dressers--chests", SortOrder = 2200, ImageUrl = "", Description = "" });
            modelBuilder.Entity<ProductType>().HasData(new ProductType { Id = 23, RoomId = 5, Name = "Nightstands", Slug = "nightstands", SortOrder = 2300, ImageUrl = "", Description = "" });
            modelBuilder.Entity<ProductType>().HasData(new ProductType { Id = 24, RoomId = 5, Name = "Vanity Tables", Slug = "vanity-tables", SortOrder = 2400, ImageUrl = "", Description = "" });
            modelBuilder.Entity<ProductType>().HasData(new ProductType { Id = 25, RoomId = 6, Name = "Media Cabinets", Slug = "Media-Cabinets", SortOrder = 2500, ImageUrl = "", Description = "" });
            modelBuilder.Entity<ProductType>().HasData(new ProductType { Id = 26, RoomId = 6, Name = "Accent Chairs", Slug = "accent-chairs", SortOrder = 2600, ImageUrl = "", Description = "" });
            modelBuilder.Entity<ProductType>().HasData(new ProductType { Id = 27, RoomId = 6, Name = "Accent Tables", Slug = "accent-tables", SortOrder = 2700, ImageUrl = "", Description = "" });
            modelBuilder.Entity<ProductType>().HasData(new ProductType { Id = 28, RoomId = 6, Name = "Center Tables", Slug = "center-tables", SortOrder = 2800, ImageUrl = "", Description = "" });
            modelBuilder.Entity<ProductType>().HasData(new ProductType { Id = 29, RoomId = 6, Name = "Cocktail Tables", Slug = "cocktail-tables", SortOrder = 2900, ImageUrl = "", Description = "" });
            modelBuilder.Entity<ProductType>().HasData(new ProductType { Id = 30, RoomId = 6, Name = "Console Tables", Slug = "console-tables", SortOrder = 3000, ImageUrl = "", Description = "" });
            modelBuilder.Entity<ProductType>().HasData(new ProductType { Id = 31, RoomId = 6, Name = "Game Tables", Slug = "game-tables", SortOrder = 3100, ImageUrl = "", Description = "" });
            modelBuilder.Entity<ProductType>().HasData(new ProductType { Id = 32, RoomId = 6, Name = "Ottomans & Stools", Slug = "ottomans--stools", SortOrder = 3200, ImageUrl = "", Description = "" });
            modelBuilder.Entity<ProductType>().HasData(new ProductType { Id = 33, RoomId = 6, Name = "Sectionals", Slug = "sectionals", SortOrder = 3300, ImageUrl = "", Description = "" });
            modelBuilder.Entity<ProductType>().HasData(new ProductType { Id = 34, RoomId = 6, Name = "Side Tables", Slug = "side-tables", SortOrder = 3400, ImageUrl = "", Description = "" });
            modelBuilder.Entity<ProductType>().HasData(new ProductType { Id = 35, RoomId = 6, Name = "Sofas & Settees", Slug = "sofas--settees", SortOrder = 3500, ImageUrl = "", Description = "" });
            modelBuilder.Entity<ProductType>().HasData(new ProductType { Id = 36, RoomId = 6, Name = "Storage Cabinets", Slug = "storage-cabinets", SortOrder = 3600, ImageUrl = "", Description = "" });

            modelBuilder.Entity<MaterialCategory>().HasData(new MaterialCategory { Id = 1, Name = "Metal" });
            modelBuilder.Entity<MaterialCategory>().HasData(new MaterialCategory { Id = 2, Name = "Upholstery Materials" });
            modelBuilder.Entity<MaterialCategory>().HasData(new MaterialCategory { Id = 3, Name = "Stone" });
            modelBuilder.Entity<MaterialCategory>().HasData(new MaterialCategory { Id = 4, Name = "Woods" });
            modelBuilder.Entity<MaterialCategory>().HasData(new MaterialCategory { Id = 5, Name = "Other Textures & Surface Treatments" });


            modelBuilder.Entity<Material>().HasData(new Material { Id = 1, MaterialCategoryId = 1, Name = "Aluminium" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 2, MaterialCategoryId = 1, Name = "Brass" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 3, MaterialCategoryId = 1, Name = "Gilt Metal" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 4, MaterialCategoryId = 1, Name = "Iron" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 5, MaterialCategoryId = 1, Name = "Nickel Plated Brass" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 6, MaterialCategoryId = 1, Name = "Paktong" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 7, MaterialCategoryId = 1, Name = "Stainless Steel" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 8, MaterialCategoryId = 1, Name = "Steel" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 9, MaterialCategoryId = 1, Name = "Zinc" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 10, MaterialCategoryId = 2, Name = "Cow Hide " });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 11, MaterialCategoryId = 2, Name = "Embossed Leather" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 12, MaterialCategoryId = 2, Name = "Fabric" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 13, MaterialCategoryId = 2, Name = "Hair on Hide" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 14, MaterialCategoryId = 2, Name = "Leather" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 15, MaterialCategoryId = 2, Name = "Silk " });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 16, MaterialCategoryId = 2, Name = "Suede" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 17, MaterialCategoryId = 2, Name = "Upholstery" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 18, MaterialCategoryId = 3, Name = "Agate" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 19, MaterialCategoryId = 3, Name = "Alabaster" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 20, MaterialCategoryId = 3, Name = "Amethyst" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 21, MaterialCategoryId = 3, Name = "Carrara Marble" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 22, MaterialCategoryId = 3, Name = "Crystal" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 23, MaterialCategoryId = 3, Name = "Iron Pyrite" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 24, MaterialCategoryId = 3, Name = "Jade" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 25, MaterialCategoryId = 3, Name = "Lapis Lazuli" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 26, MaterialCategoryId = 3, Name = "Malachite" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 27, MaterialCategoryId = 3, Name = "Marble" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 28, MaterialCategoryId = 3, Name = "Onyx" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 29, MaterialCategoryId = 3, Name = "Quartz" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 30, MaterialCategoryId = 3, Name = "Red Jasper" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 31, MaterialCategoryId = 3, Name = "Soapstone" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 32, MaterialCategoryId = 3, Name = "Tiger Eye" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 33, MaterialCategoryId = 3, Name = "Travertine" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 34, MaterialCategoryId = 3, Name = "Turquoise Stone" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 35, MaterialCategoryId = 3, Name = "Variegated Black Marble" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 36, MaterialCategoryId = 4, Name = "Acacia" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 37, MaterialCategoryId = 4, Name = "Acacia Oyster Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 38, MaterialCategoryId = 4, Name = "Acacia Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 39, MaterialCategoryId = 4, Name = "Aged Oak Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 40, MaterialCategoryId = 4, Name = "Alder" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 41, MaterialCategoryId = 4, Name = "Amara Ebony Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 42, MaterialCategoryId = 4, Name = "Amara grained Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 43, MaterialCategoryId = 4, Name = "Amara Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 44, MaterialCategoryId = 4, Name = "Amarello Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 45, MaterialCategoryId = 4, Name = "Amboyna Burl" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 46, MaterialCategoryId = 4, Name = "Amboyna Burl Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 47, MaterialCategoryId = 4, Name = "Amotique Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 48, MaterialCategoryId = 4, Name = "Anagre Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 49, MaterialCategoryId = 4, Name = "Argentinean Walnut Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 50, MaterialCategoryId = 4, Name = "Ash Burl Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 51, MaterialCategoryId = 4, Name = "Ash Crown Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 52, MaterialCategoryId = 4, Name = "Ash Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 53, MaterialCategoryId = 4, Name = "Bamboo" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 54, MaterialCategoryId = 4, Name = "Beech" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 55, MaterialCategoryId = 4, Name = "Birds Eye Maple Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 56, MaterialCategoryId = 4, Name = "Block Anegre" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 57, MaterialCategoryId = 4, Name = "Bocote Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 58, MaterialCategoryId = 4, Name = "Brown Oak Burl" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 59, MaterialCategoryId = 4, Name = "Bubinga Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 60, MaterialCategoryId = 4, Name = "Cerejeira Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 61, MaterialCategoryId = 4, Name = "Cerejeria Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 62, MaterialCategoryId = 4, Name = "Cherry" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 63, MaterialCategoryId = 4, Name = "Cherry Crown Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 64, MaterialCategoryId = 4, Name = "Cherry Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 65, MaterialCategoryId = 4, Name = "Cherry Wood" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 66, MaterialCategoryId = 4, Name = "Chestnut Burl" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 67, MaterialCategoryId = 4, Name = "Chestnut Burl Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 68, MaterialCategoryId = 4, Name = "Chestnut Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 69, MaterialCategoryId = 4, Name = "Curly Maple Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 70, MaterialCategoryId = 4, Name = "Dragonwood" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 71, MaterialCategoryId = 4, Name = "Ebony Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 72, MaterialCategoryId = 4, Name = "Elm Burl Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 73, MaterialCategoryId = 4, Name = "Engineered Ebony Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 74, MaterialCategoryId = 4, Name = "Etimoe Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 75, MaterialCategoryId = 4, Name = "Fiddle Back Maple Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 76, MaterialCategoryId = 4, Name = "Fiddle Back Sycamore Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 77, MaterialCategoryId = 4, Name = "Figured Anegre Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 78, MaterialCategoryId = 4, Name = "Figured Ash Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 79, MaterialCategoryId = 4, Name = "Figured Birch" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 80, MaterialCategoryId = 4, Name = "Figured Etimoe Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 81, MaterialCategoryId = 4, Name = "Figured Eucalyptus Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 82, MaterialCategoryId = 4, Name = "Figured Makore" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 83, MaterialCategoryId = 4, Name = "Figured Ofram" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 84, MaterialCategoryId = 4, Name = "Figured Ofram Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 85, MaterialCategoryId = 4, Name = "Figured Sycamore Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 86, MaterialCategoryId = 4, Name = "Figured Walnut Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 87, MaterialCategoryId = 4, Name = "Flame Bubinga Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 88, MaterialCategoryId = 4, Name = "Flame Figured Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 89, MaterialCategoryId = 4, Name = "Flame Mahogany" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 90, MaterialCategoryId = 4, Name = "Flame Mahogany Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 91, MaterialCategoryId = 4, Name = "Flame Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 92, MaterialCategoryId = 4, Name = "Flame Walnut" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 93, MaterialCategoryId = 4, Name = "Flame Walnut Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 94, MaterialCategoryId = 4, Name = "Fumed Figured Eucalyptus Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 95, MaterialCategoryId = 4, Name = "Fumed Mahogany Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 96, MaterialCategoryId = 4, Name = "Golden Madrone Burl Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 97, MaterialCategoryId = 4, Name = "Golden Madrone Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 98, MaterialCategoryId = 4, Name = "Granadillo Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 99, MaterialCategoryId = 4, Name = "Grey Vine Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 100, MaterialCategoryId = 4, Name = "Hickory Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 101, MaterialCategoryId = 4, Name = "Hyedua Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 102, MaterialCategoryId = 4, Name = "Imbuya Burl Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 103, MaterialCategoryId = 4, Name = "Imbuya Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 104, MaterialCategoryId = 4, Name = "Karelian Birch Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 105, MaterialCategoryId = 4, Name = "Khaya" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 106, MaterialCategoryId = 4, Name = "Khaya Crotch Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 107, MaterialCategoryId = 4, Name = "Khaya Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 108, MaterialCategoryId = 4, Name = "Lacewood Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 109, MaterialCategoryId = 4, Name = "Lati Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 110, MaterialCategoryId = 4, Name = "Laurel Burl Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 111, MaterialCategoryId = 4, Name = "Layered Hardwood" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 112, MaterialCategoryId = 4, Name = "Lenga" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 113, MaterialCategoryId = 4, Name = "Louro Preto Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 114, MaterialCategoryId = 4, Name = "Macassar Ebony Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 115, MaterialCategoryId = 4, Name = "Madrone Burl Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 116, MaterialCategoryId = 4, Name = "Mahogany" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 117, MaterialCategoryId = 4, Name = "Mahogany Swirl" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 118, MaterialCategoryId = 4, Name = "Mahogany Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 119, MaterialCategoryId = 4, Name = "Maple" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 120, MaterialCategoryId = 4, Name = "Maple Burl Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 121, MaterialCategoryId = 4, Name = "Maple Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 122, MaterialCategoryId = 4, Name = "Marbled Sapele" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 123, MaterialCategoryId = 4, Name = "Morado Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 124, MaterialCategoryId = 4, Name = "Movingue" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 125, MaterialCategoryId = 4, Name = "Movingue Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 126, MaterialCategoryId = 4, Name = "Oak" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 127, MaterialCategoryId = 4, Name = "Oak Burl Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 128, MaterialCategoryId = 4, Name = "Oak Heart Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 129, MaterialCategoryId = 4, Name = "Oak Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 130, MaterialCategoryId = 4, Name = "Ofram Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 131, MaterialCategoryId = 4, Name = "Okoume Veneer/Mop Inlay" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 132, MaterialCategoryId = 4, Name = "Okumé Crotch Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 133, MaterialCategoryId = 4, Name = "Okumé Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 134, MaterialCategoryId = 4, Name = "Olive Ash Burl Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 135, MaterialCategoryId = 4, Name = "Olive Ash Swirl Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 136, MaterialCategoryId = 4, Name = "Oyster Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 137, MaterialCategoryId = 4, Name = "Pacific walnut" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 138, MaterialCategoryId = 4, Name = "Pacific Walnut Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 139, MaterialCategoryId = 4, Name = "Paldao Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 140, MaterialCategoryId = 4, Name = "Parawood" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 141, MaterialCategoryId = 4, Name = "Parchment" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 142, MaterialCategoryId = 4, Name = "Pepperwood Burl Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 143, MaterialCategoryId = 4, Name = "Perota Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 144, MaterialCategoryId = 4, Name = "Pine" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 145, MaterialCategoryId = 4, Name = "Pippy Oak Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 146, MaterialCategoryId = 4, Name = "Pollard Burl Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 147, MaterialCategoryId = 4, Name = "Pollard Oak Burl" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 148, MaterialCategoryId = 4, Name = "Pollard Oak Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 149, MaterialCategoryId = 4, Name = "Poplar" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 150, MaterialCategoryId = 4, Name = "Poplar Burl Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 151, MaterialCategoryId = 4, Name = "Primavera Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 152, MaterialCategoryId = 4, Name = "Quartered Etimoe Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 153, MaterialCategoryId = 4, Name = "Reclaimed Oak Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 154, MaterialCategoryId = 4, Name = "Redwood Burl Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 155, MaterialCategoryId = 4, Name = "Rosewood Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 156, MaterialCategoryId = 4, Name = "Santo Domingo Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 157, MaterialCategoryId = 4, Name = "Sapele" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 158, MaterialCategoryId = 4, Name = "Satinwood Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 159, MaterialCategoryId = 4, Name = "Simulated Amara Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 160, MaterialCategoryId = 4, Name = "Simulated Ebony Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 161, MaterialCategoryId = 4, Name = "Solid Babool" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 162, MaterialCategoryId = 4, Name = "Solid Wood" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 163, MaterialCategoryId = 4, Name = "Sucupira Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 164, MaterialCategoryId = 4, Name = "Swirl Mahogany Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 165, MaterialCategoryId = 4, Name = "Swirl Walnut Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 166, MaterialCategoryId = 4, Name = "Sycamore Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 167, MaterialCategoryId = 4, Name = "Tamo Ash Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 168, MaterialCategoryId = 4, Name = "Tamo Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 169, MaterialCategoryId = 4, Name = "Tiger Maple Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 170, MaterialCategoryId = 4, Name = "Tulip" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 171, MaterialCategoryId = 4, Name = "Tulip Wood" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 172, MaterialCategoryId = 4, Name = "Tulipifera" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 173, MaterialCategoryId = 4, Name = "Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 174, MaterialCategoryId = 4, Name = "Walnut" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 175, MaterialCategoryId = 4, Name = "Walnut Burl Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 176, MaterialCategoryId = 4, Name = "Walnut Crown Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 177, MaterialCategoryId = 4, Name = "Walnut Grained Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 178, MaterialCategoryId = 4, Name = "Walnut Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 179, MaterialCategoryId = 4, Name = "Waterfall Bubinga Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 180, MaterialCategoryId = 4, Name = "Wenge Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 181, MaterialCategoryId = 4, Name = "Wood" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 182, MaterialCategoryId = 4, Name = "Woven Cane" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 183, MaterialCategoryId = 4, Name = "Woven Rattan" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 184, MaterialCategoryId = 4, Name = "Yew Burl Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 185, MaterialCategoryId = 4, Name = "Yew Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 186, MaterialCategoryId = 4, Name = "Zebrano Veneer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 187, MaterialCategoryId = 5, Name = "Acrylic" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 188, MaterialCategoryId = 5, Name = "Bone" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 189, MaterialCategoryId = 5, Name = "Buffalo Horn" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 190, MaterialCategoryId = 5, Name = "Cane" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 191, MaterialCategoryId = 5, Name = "Canvas" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 192, MaterialCategoryId = 5, Name = "Ceramic" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 193, MaterialCategoryId = 5, Name = "Composite" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 194, MaterialCategoryId = 5, Name = "Découpage" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 195, MaterialCategoryId = 5, Name = "Eggshell" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 196, MaterialCategoryId = 5, Name = "Faux Bone" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 197, MaterialCategoryId = 5, Name = "Faux Horn" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 198, MaterialCategoryId = 5, Name = "Faux Shagreen" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 199, MaterialCategoryId = 5, Name = "Felt" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 200, MaterialCategoryId = 5, Name = "Fiberglass" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 201, MaterialCategoryId = 5, Name = "Glass" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 202, MaterialCategoryId = 5, Name = "Horn" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 203, MaterialCategoryId = 5, Name = "Kalahari" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 204, MaterialCategoryId = 5, Name = "Komodo" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 205, MaterialCategoryId = 5, Name = "Lacquer" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 206, MaterialCategoryId = 5, Name = "Mirror" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 207, MaterialCategoryId = 5, Name = "Mother of Pearl" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 208, MaterialCategoryId = 5, Name = "Paper" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 209, MaterialCategoryId = 5, Name = "Penshell" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 210, MaterialCategoryId = 5, Name = "Rush" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 211, MaterialCategoryId = 5, Name = "Shagreen" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 212, MaterialCategoryId = 5, Name = "Shagreen Embossed Leather" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 213, MaterialCategoryId = 5, Name = "Velvet" });
            modelBuilder.Entity<Material>().HasData(new Material { Id = 214, MaterialCategoryId = 5, Name = "Zebra Dyed Cow Hide" });

            modelBuilder.Entity<Care>().HasData(new Care { Id = 1, Name = "Wood", ContentTitle = "Wood", ContentBody = "<p>Frequently dust exposed surfaces with a clean, damp natural cloth. Dry the surface with another clean, dry cloth. Infrequently polish your furniture (a few times a year at most) with a non-silicon-base furniture polish made by a reputable manufacturer, taking care to follow the instructions. Bear in mind that one manufacturer’s furniture care products should never be used in combination with another. Product formulations are unique to each manufacturer and are made to blend with another, so using different polishes may cause build-up that can appear cloudy or dull over time, and/or feel sticky to the touch. Always polish or dust with a motion that follows the grain of the wood to avoid scratching the surface, and allow polish to dry completely before replacing any objects on the surface.</p>", ContentImageS7 = "Wood", SortOrder = 10, DisplayName = "Wood", IamgeUrl = "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg" });
            modelBuilder.Entity<Care>().HasData(new Care { Id = 2, Name = "Artistry", ContentTitle = "Artistry", ContentBody = "<p>Theodore Alexander artists painstakingly create our hand-painted finishes using meticulous brushstrokes and age-old techniques. You can use a good quality furniture polish to maintain and preserve the unique artwork. Take care not to use abrasive cloths or polishes that may scratch a hand-painted finish.</p><ul><li>• Eglomisé – Eglomisé is a hand-made, centuries-old process that creates a stunning reflective surface. Regularly dust with a feather duster and wipe clean with a damp, lint-free cloth.</li><li>• Argento – The Argento finish from Theodore Alexander is the result of an exclusive finishing process. From time to time, wipe clean with a soft, damp cloth, taking care not to over-wet the surface.</li></ul>", ContentImageS7 = "Artistry", SortOrder = 10, DisplayName = "Artistry", IamgeUrl = "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg" });
            modelBuilder.Entity<Care>().HasData(new Care { Id = 3, Name = "Upholstery", ContentTitle = "Upholstery", ContentBody = "<p>Remove all loose cushions. Loosen dirt with a hand-held dusting brush while using a vacuum brush attachment to remove dust. Vacuum all surfaces of the furniture: back, sides, arms, skirt (if applicable) and the platform beneath the cushions. Vacuum both sides of the loose cushions.</p><p>When necessary, you can use commercially available cleaners on Theodore Alexander upholstery. Be sure to test on an inconspicuous area first. For day-to-day cleaning use a soft clean damp cloth.</p>", ContentImageS7 = "Upholstery", SortOrder = 10, DisplayName = "Upholstery", IamgeUrl = "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg" });
            modelBuilder.Entity<Care>().HasData(new Care { Id = 4, Name = "Leather", ContentTitle = "Leather", ContentBody = "<p>Leather is a naturally hard-wearing and versatile material that will gain a characteristic and pleasing patina over time. Leather will show natural marks with wrinkles, scars, scratches and bites which are all normal. It is these characteristics that differentiate real hide from synthetic or re-constituted coverings. Take care not to expose your leather or hide product to continuous direct sunlight as this might  lead to fading.</p><p>For accidental spills, try to wipe up immediately and don’t allow the stain to dry. Light stains can be removed with a diluted solution of a neutral soap in lukewarm water, but be careful not to soak the leather or hide. Occasionally, pencil marks and other light marks can be removed by rubbing the area lightly with an eraser. If your leather or hide is heavily soiled, we recommend professional cleaning.</p>", ContentImageS7 = "Leather", SortOrder = 10, DisplayName = "Leather", IamgeUrl = "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg" });
            modelBuilder.Entity<Care>().HasData(new Care { Id = 5, Name = "Lampshades", ContentTitle = "Lampshades", ContentBody = "<p>Theodore Alexander lampshades are meticulously handmade by skilled craftspeople. Most shades simply require a light dusting with a feather duster or soft brush to remove dust. Vacuum using smooth, light strokes with the small bristle attachment found on most vacuum cleaners, or gently wipe with a soft, clean cloth.</p>", ContentImageS7 = "Lampshades", SortOrder = 10, DisplayName = "Lampshades", IamgeUrl = "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg" });
            modelBuilder.Entity<Care>().HasData(new Care { Id = 6, Name = "Etched Brass", ContentTitle = "Etched Brass", ContentBody = "<p>The plain brass and etched tops and panels used on Theodore Alexander furniture require particular care during use and cleaning. Each panel has a rich patina created by a process of natural oxidization that leads to the deep colouration. Having been created by natural elements, etched brass is particularly sensitive to certain compounds and liquids, particularly those with abrasive or acidic bases. This includes wine, spirits and some furniture creams.</p><p>We recommend you take precautions to avoid spills and scratches by using coasters and placemats. Should a spill occur it must be wiped up immediately with a soft, clean cloth. Scratches may be touched up using a dark coloured shoe wax. </p><p>Over time you may see some colouration changes in the finish, such as a soft mottling. This is perfectly natural as the oxidization process continues and will in no way detract from the beauty of the item. </p><p>For everyday cleaning we recommend that you use only a soft, natural fibre cloth and a small amount of oil soap. </p>", ContentImageS7 = "Etched Brass", SortOrder = 10, DisplayName = "Etched Brass", IamgeUrl = "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg" });
            modelBuilder.Entity<Care>().HasData(new Care { Id = 7, Name = "Brass Inlay", ContentTitle = "Brass Inlay", ContentBody = "Each piece of brass inlay is carefully inset by hand by a Theodore Alexander artisan. Simply wipe clean using a soft, damp cloth and a gentle hand.", ContentImageS7 = "Brass Inlay", SortOrder = 10, DisplayName = "Brass Inlay", IamgeUrl = "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg" });
            modelBuilder.Entity<Care>().HasData(new Care { Id = 8, Name = "Iron", ContentTitle = "Iron", ContentBody = "Regularly dust and wipe clean with a good quality furniture polish twice each month. Avoid using soap and water or any water-based cleaning products on iron as this may cause rusting.", ContentImageS7 = "Iron", SortOrder = 10, DisplayName = "Iron", IamgeUrl = "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg" });
            modelBuilder.Entity<Care>().HasData(new Care { Id = 9, Name = "Brass", ContentTitle = "Brass", ContentBody = "Brass artworks are hand cast in our own foundry, using age-old techniques. Occasional application of an inert wax that does not contain a cleansing agent will preserve the patina of the metal. Avoid using abrasive cloths or polishes that may damage the surface.", ContentImageS7 = "Brass", SortOrder = 10, DisplayName = "Brass", IamgeUrl = "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg" });
            modelBuilder.Entity<Care>().HasData(new Care { Id = 10, Name = "Stainless Steel", ContentTitle = "Stainless Steel", ContentBody = "<p>Warm water and a soft, lint-free cloth are ideal for routine cleaning. Wipe in the direction of the polish lines and dry with a towel or cloth to prevent water spots. Stainless steel cleaner cloths can help minimize scratching, remove stains and polish stainless steel surfaces nicely. Be sure to test in an inconspicuous spot.</p>", ContentImageS7 = "Stainless Steel", SortOrder = 10, DisplayName = "Stainless Steel", IamgeUrl = "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg" });
            modelBuilder.Entity<Care>().HasData(new Care { Id = 11, Name = "Nickel Plate", ContentTitle = "Nickel Plate", ContentBody = "Rub piece with a non-abrasive nickel-plate cleanser and a clean, dry cloth. Buff gently with smooth strokes to restore lustre.", ContentImageS7 = "Nickel Plate", SortOrder = 10, DisplayName = "Nickel Plate", IamgeUrl = "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg" });
            modelBuilder.Entity<Care>().HasData(new Care { Id = 12, Name = "Stone", ContentTitle = "Stone", ContentBody = "<p>Coasters should be used under all glasses, particularly those with alcohol or citrus content. Avoid placing hot items directly on the stone surface. Trivets or mats should be used under hot dishes and placemats under china, ceramics, silver or other objects that could scratch the surface. For calcareous (chalky) stones, many common foods and drinks that contain acids will etch or dull the surface.</p><ul><li>Clean stone surfaces with a few drops of neutral cleaner, stone soap, or a mild liquid dishwashing detergent and warm water. Use a clean soft cloth for best results. Excessive cleaner or soap could leave a film and cause streaks. Do not use products that contain lemon, vinegar, or other acids or bleach on marble or limestone. The surface should be thoroughly rinsed after washing with the soap solution and dried with a soft cloth. Avoid the use of scouring powders or creams; these abrasives will scratch the surface.</li></ul>", ContentImageS7 = "Stone", SortOrder = 10, DisplayName = "Nickel Plate", IamgeUrl = "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg" });
            modelBuilder.Entity<Care>().HasData(new Care { Id = 13, Name = "Bone / Horn", ContentTitle = "Bone / Horn", ContentBody = "A light dusting with a soft brush is all that is needed to clean bone, horn and antler objects. Bone and horn that are in good condition (that is with a smooth, glossy surface) and have no applied decoration can be cleaned with a little water and a soft, clean cloth. Dry the object immediately with another cloth.", ContentImageS7 = "Bone / Horn", SortOrder = 10, DisplayName = "Bone / Horn", IamgeUrl = "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg" });
            modelBuilder.Entity<Care>().HasData(new Care { Id = 14, Name = "Hand Painting Eglomisé", ContentTitle = "Hand Painting Eglomisé", ContentBody = "<p>Theodore Alexander artists painstakingly create our hand-painted finishes using meticulous brushstrokes and age-old techniques. You can use a good quality furniture polish to maintain and preserve the unique artwork. Take care not to use abrasive cloths or polishes that may scratch a hand-painted finish.</p><ul><li>• Eglomisé – Eglomisé is a hand-made, centuries-old process that creates a stunning reflective surface. Regularly dust with a feather duster and wipe clean with a damp, lint-free cloth.</li><li>• Argento – The Argento finish from Theodore Alexander is the result of an exclusive finishing process. From time to time, wipe clean with a soft, damp cloth, taking care not to over-wet the surface.</li></ul>", ContentImageS7 = "Hand Painting Eglomisé", SortOrder = 10, DisplayName = "Hand Painting Eglomisé", IamgeUrl = "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg" });
            modelBuilder.Entity<Care>().HasData(new Care { Id = 15, Name = "Glass", ContentTitle = "Glass", ContentBody = "Hand-blown glass is created by artisans and each piece is unique. There will be variations in shape and form that are illustrative of the hand-made nature of each piece. Hand-blown glass tends to be more delicate than mass-produced glass and we recommend gentle cleaning with a damp, soft cloth to maintain the lustre and beauty of the original piece.", ContentImageS7 = "Glass", SortOrder = 10, DisplayName = "Glass", IamgeUrl = "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg" });
            modelBuilder.Entity<Care>().HasData(new Care { Id = 16, Name = "Crotch", ContentTitle = "Crotch", ContentBody = "Once a week, dust exposed surfaces with a clean and moist cotton cloth. Then dry the surface with a clean and dry cloth. Once a month, polish your furniture with a non-silicone good quality paste wax made by a reputable manufacturer, taking care to follow the instructions. Always polish or dust with a motion that follows the grain of the wood to avoid scratching the surface, and allow polish to dry completely before replacing any objects on the surface. For greasy stains or waxy build-up use a diluted dish detergent which should be wiped on with a clean cloth and removed with another. The whole affected surface should be waxed after this process to maintain consistency in protection.", ContentImageS7 = "Crotch", SortOrder = 10, DisplayName = "Crotch", IamgeUrl = "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg" });
            modelBuilder.Entity<Care>().HasData(new Care { Id = 17, Name = "Acrylic", ContentTitle = "Acrylic", ContentBody = "<p>Dust with a soft, damp cloth or chamois. Dry or gritty cloths may cause surface scratches and create a static electric charge on the surface. Clean Acrylic with a solution of mild soap or detergent and lukewarm water. Use a clean soft cloth, applying only light pressure. Rinse with clean water and dry by blotting with a damp cloth or chamois. DO NOT USE: Window cleaning sprays, kitchen scouring compounds or solvents such as acetone, gasoline, benzene, alcohol, carbon tetrachloride, or lacquer thinner. These can scratch the surface and/or weaken it causing small surface cracks called, “crazing.”</p>", ContentImageS7 = "Acrylic", SortOrder = 10, DisplayName = "Acrylic", IamgeUrl = "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg" });
            modelBuilder.Entity<Care>().HasData(new Care { Id = 18, Name = "COMPOSITE", ContentTitle = "COMPOSITE", ContentBody = "<p>Coasters should be used under all glasses, particularly those with alcohol or citrus content. Avoid placing hot items directly on the surface. Trivets or mats should be used under hot dishes and placemats under china, ceramics, silver or other objects that could scratch the surface. Many common foods and drinks that contain acids can etch or dull the surface.</p><ul><li>Clean surfaces with a few drops of neutral cleaner, or a mild liquid dishwashing detergent and warm water. Use a clean soft cloth for best results. Excessive cleaner or soap could leave a film and cause streaks. Thoroughly wipe surface with a water dampened soft cloth to remove any remaining soap. Avoid the use of scouring powders or creams; these abrasives will scratch the surface. Do not use products that contain lemon, vinegar, or other acids or bleach.</li></ul>", ContentImageS7 = "COMPOSITE", SortOrder = 10, DisplayName = "COMPOSITE", IamgeUrl = "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg" });
            modelBuilder.Entity<Care>().HasData(new Care { Id = 19, Name = "Eggshell", ContentTitle = "Eggshell", ContentBody = "<p>Clean with a damp, clean cloth. Avoid using cleansers with a highly acidic base or ones that are extremely abrasive. Cleaners formulated with bleach can also damage eggshell pieces, particularly those with a polished or coated finish.</p>", ContentImageS7 = "Eggshell", SortOrder = 10, DisplayName = "Eggshell", IamgeUrl = "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg" });
            modelBuilder.Entity<Care>().HasData(new Care { Id = 20, Name = "Aluminium", ContentTitle = "Aluminium", ContentBody = "<p>Regularly dust and wipe clean with a good quality furniture polish twice each month. Avoid using soap and water or any water-based cleaning products on aluminum as this may cause tarnishing.</p>", ContentImageS7 = "Aluminium", SortOrder = 10, DisplayName = "Aluminium", IamgeUrl = "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg" });
            modelBuilder.Entity<Care>().HasData(new Care { Id = 21, Name = "Steel", ContentTitle = "Steel", ContentBody = "<p>Regularly dust and wipe clean with a good quality furniture polish twice each month. Avoid using soap and water or any water-based cleaning products on steel as this may cause rusting.</p>", ContentImageS7 = "Steel", SortOrder = 10, DisplayName = "Steel", IamgeUrl = "https://theodorealexander.sirv.com/website/Frontend/Live/assests/furniture-care/wood.jpg" });

            modelBuilder.Entity<Region>().HasData(
                new Region { Id = 1, Code = "US", Name = "United States", Currency = "USD", Description = "North American Region", Latitude = 37.0902, Longitude = -95.7129 },
                new Region { Id = 2, Code = "VN", Name = "Vietnam", Currency = "VND", Description = "Southeast Asia Region", Latitude = 14.0583, Longitude = 108.2772 },
                new Region { Id = 3, Code = "GB", Name = "United Kingdom", Currency = "GBP", Description = "European Region", Latitude = 55.3781, Longitude = -3.4360 },
                new Region { Id = 4, Code = "SG", Name = "Singapore", Currency = "SGD", Description = "Southeast Asia Hub", Latitude = 1.3521, Longitude = 103.8198 },
                new Region { Id = 5, Code = "CN", Name = "China", Currency = "CNY", Description = "East Asia Region", Latitude = 35.8617, Longitude = 104.1954 },
                new Region { Id = 6, Code = "RU", Name = "Russia", Currency = "RUB", Description = "Eurasia Region", Latitude = 61.5240, Longitude = 105.3188 },
                new Region { Id = 7, Code = "ID", Name = "Indonesia", Currency = "IDR", Description = "Southeast Asia Archipelago", Latitude = -0.7893, Longitude = 113.9213 },
                new Region { Id = 8, Code = "CA", Name = "Canada", Currency = "CAD", Description = "North American Region", Latitude = 56.1304, Longitude = -106.3468 },
                new Region { Id = 9, Code = "MX", Name = "Mexico", Currency = "MXN", Description = "North American Region", Latitude = 23.6345, Longitude = -102.5528 },
                new Region { Id = 10, Code = "BR", Name = "Brazil", Currency = "BRL", Description = "South American Region", Latitude = -14.2350, Longitude = -51.9253 },
                new Region { Id = 11, Code = "DE", Name = "Germany", Currency = "EUR", Description = "European Region", Latitude = 51.1657, Longitude = 10.4515 },
                new Region { Id = 12, Code = "IT", Name = "Italy", Currency = "EUR", Description = "European Region", Latitude = 41.8719, Longitude = 12.5674 },
                new Region { Id = 13, Code = "ES", Name = "Spain", Currency = "EUR", Description = "European Region", Latitude = 40.4637, Longitude = -3.7492 },
                new Region { Id = 14, Code = "AU", Name = "Australia", Currency = "AUD", Description = "Oceania Region", Latitude = -25.2744, Longitude = 133.7751 },
                new Region { Id = 15, Code = "JP", Name = "Japan", Currency = "JPY", Description = "East Asia Region", Latitude = 36.2048, Longitude = 138.2529 },
                new Region { Id = 16, Code = "IN", Name = "India", Currency = "INR", Description = "South Asia Region", Latitude = 20.5937, Longitude = 78.9629 },
                new Region { Id = 17, Code = "AE", Name = "United Arab Emirates", Currency = "AED", Description = "Middle East Region", Latitude = 23.4241, Longitude = 53.8478 },
                new Region { Id = 18, Code = "ZA", Name = "South Africa", Currency = "ZAR", Description = "African Regio", Latitude = -30.5595, Longitude = 22.9375 },
                new Region { Id = 19, Code = "KR", Name = "South Korea", Currency = "KRW", Description = "East Asia Region", Latitude = 35.9078, Longitude = 127.7669 },
                new Region { Id = 20, Code = "PH", Name = "Philippines", Currency = "PHP", Description = "Southeast Asia Region", Latitude = 12.8797, Longitude = 121.7740 }
            );

            modelBuilder.Entity<ShippingZone>().HasData(
                new ShippingZone { Id = 101, Name = "Vietnam Export Hub", RegionId = 2, Description = "Major export ports in Vietnam (HCM, Hai Phong)" },
                new ShippingZone { Id = 102, Name = "US West Coast Freight Hub", RegionId = 1, Description = "Major import ports on US West Coast (LA, Long Beach, Seattle)" },
                new ShippingZone { Id = 103, Name = "Los Angeles Metro Area", RegionId = 1, Description = "Last-mile delivery area for Los Angeles County" },
                new ShippingZone { Id = 104, Name = "Vietnam Southern Region", RegionId = 2, Description = "Southern provinces including Ho Chi Minh City" },
                new ShippingZone { Id = 105, Name = "Vietnam Northern Region", RegionId = 2, Description = "Northern provinces including Hanoi" },
                new ShippingZone { Id = 106, Name = "UK Freight Hub", RegionId = 3, Description = "Major import ports in United Kingdom" },
                new ShippingZone { Id = 107, Name = "London Metro Area", RegionId = 3, Description = "Last-mile delivery for London" },
                new ShippingZone { Id = 108, Name = "China Export Hub", RegionId = 5, Description = "Major export ports in China (Shenzhen, Shanghai)" },
                new ShippingZone { Id = 109, Name = "Russia Moscow Area", RegionId = 6, Description = "Moscow and surrounding regions" },
                new ShippingZone { Id = 110, Name = "Indonesia Jakarta Area", RegionId = 7, Description = "Jakarta and surrounding regions" },
                new ShippingZone { Id = 111, Name = "Singapore Main Island", RegionId = 4, Description = "Main island of Singapore" }
            );

            modelBuilder.Entity<ShippingZoneDetail>().HasData(
                new ShippingZoneDetail { Id = 1, ShippingZoneId = 103, DetailType = ZoneDetailType.ZipCodePrefix, Value = "900", Description = "Los Angeles City (900xx zip codes)" },
                new ShippingZoneDetail { Id = 2, ShippingZoneId = 104, DetailType = ZoneDetailType.StateProvince, Value = "Ho Chi Minh City", Description = "TP.HCM" },
                new ShippingZoneDetail { Id = 3, ShippingZoneId = 105, DetailType = ZoneDetailType.StateProvince, Value = "Hanoi", Description = "Hà Nội" },
                new ShippingZoneDetail { Id = 4, ShippingZoneId = 107, DetailType = ZoneDetailType.ZipCodePrefix, Value = "EC", Description = "East Central London" },
                new ShippingZoneDetail { Id = 5, ShippingZoneId = 107, DetailType = ZoneDetailType.ZipCodePrefix, Value = "W1", Description = "West End London" },
                new ShippingZoneDetail { Id = 6, ShippingZoneId = 109, DetailType = ZoneDetailType.StateProvince, Value = "Moscow Oblast", Description = "Moscow and surrounding oblast" },
                new ShippingZoneDetail { Id = 7, ShippingZoneId = 110, DetailType = ZoneDetailType.StateProvince, Value = "Jakarta", Description = "Jakarta Province" },
                new ShippingZoneDetail { Id = 8, ShippingZoneId = 111, DetailType = ZoneDetailType.Country, Value = "SG", Description = "All of Singapore" }
            );

            modelBuilder.Entity<ShippingServiceLevel>().HasData(
                 new ShippingServiceLevel { Id = 1, Name = "International Standard Ocean Freight", Description = "Bulk freight via ocean, port-to-port", EstimatedDeliveryDaysMin = 25, EstimatedDeliveryDaysMax = 40, DeliveryType = DeliveryType.StandardCurbside, IncludesAssembly = false, RequiresSpecialHandling = true },
                 new ShippingServiceLevel { Id = 2, Name = "White Glove Delivery (Domestic)", Description = "Last-mile delivery, includes unboxing & assembly", EstimatedDeliveryDaysMin = 3, EstimatedDeliveryDaysMax = 7, DeliveryType = DeliveryType.WhiteGlove, IncludesAssembly = true, RequiresSpecialHandling = false },
                 new ShippingServiceLevel { Id = 3, Name = "International Air Freight (Expedited)", Description = "Faster air cargo, port-to-port", EstimatedDeliveryDaysMin = 7, EstimatedDeliveryDaysMax = 14, DeliveryType = DeliveryType.StandardCurbside, IncludesAssembly = false, RequiresSpecialHandling = true },
                 new ShippingServiceLevel { Id = 4, Name = "Standard Domestic Freight (VN)", Description = "Standard road freight within Vietnam", EstimatedDeliveryDaysMin = 2, EstimatedDeliveryDaysMax = 5, DeliveryType = DeliveryType.ThresholdDelivery, IncludesAssembly = false, RequiresSpecialHandling = false },
                 new ShippingServiceLevel { Id = 5, Name = "Standard Domestic Freight (US)", Description = "Standard road freight within US", EstimatedDeliveryDaysMin = 3, EstimatedDeliveryDaysMax = 10, DeliveryType = DeliveryType.ThresholdDelivery, IncludesAssembly = false, RequiresSpecialHandling = false },
                 new ShippingServiceLevel { Id = 6, Name = "Domestic White Glove (ID)", Description = "Local delivery with assembly in Indonesia", EstimatedDeliveryDaysMin = 2, EstimatedDeliveryDaysMax = 5, DeliveryType = DeliveryType.WhiteGlove, IncludesAssembly = true, RequiresSpecialHandling = false },
                 new ShippingServiceLevel { Id = 7, Name = "International Rail Freight", Description = "Freight via rail, suitable for Eurasia", EstimatedDeliveryDaysMin = 15, EstimatedDeliveryDaysMax = 25, DeliveryType = DeliveryType.StandardCurbside, IncludesAssembly = false, RequiresSpecialHandling = true }
             );

            modelBuilder.Entity<GlobalShippingLane>().HasData(
                new GlobalShippingLane { Id = 1, Name = "VN to US West Coast (Ocean)", OriginShippingZoneId = 101, DestinationShippingZoneId = 102, PrimaryCarrierPartner = "Maersk", TransitMode = "Ocean", EstimatedTransitDaysMin = 20, EstimatedTransitDaysMax = 35, SupportsConsolidation = true },
                new GlobalShippingLane { Id = 2, Name = "VN to US West Coast (Air)", OriginShippingZoneId = 101, DestinationShippingZoneId = 102, PrimaryCarrierPartner = "FedEx Cargo", TransitMode = "Air Cargo", EstimatedTransitDaysMin = 5, EstimatedTransitDaysMax = 10, SupportsConsolidation = false },
                new GlobalShippingLane { Id = 3, Name = "VN to UK (Ocean)", OriginShippingZoneId = 101, DestinationShippingZoneId = 106, PrimaryCarrierPartner = "CMA CGM", TransitMode = "Ocean", EstimatedTransitDaysMin = 28, EstimatedTransitDaysMax = 45, SupportsConsolidation = true },
                new GlobalShippingLane { Id = 4, Name = "CN to US West Coast (Ocean)", OriginShippingZoneId = 108, DestinationShippingZoneId = 102, PrimaryCarrierPartner = "COSCO", TransitMode = "Ocean", EstimatedTransitDaysMin = 18, EstimatedTransitDaysMax = 30, SupportsConsolidation = true },
                new GlobalShippingLane { Id = 5, Name = "VN to Singapore (Ocean)", OriginShippingZoneId = 101, DestinationShippingZoneId = 111, PrimaryCarrierPartner = "PIL", TransitMode = "Ocean", EstimatedTransitDaysMin = 3, EstimatedTransitDaysMax = 7, SupportsConsolidation = true },
                new GlobalShippingLane { Id = 6, Name = "Singapore to Indonesia (Ocean)", OriginShippingZoneId = 111, DestinationShippingZoneId = 110, PrimaryCarrierPartner = "APL", TransitMode = "Ocean", EstimatedTransitDaysMin = 2, EstimatedTransitDaysMax = 5, SupportsConsolidation = true },
                new GlobalShippingLane { Id = 7, Name = "CN to Russia (Rail Freight)", OriginShippingZoneId = 108, DestinationShippingZoneId = 109, PrimaryCarrierPartner = "CR Express", TransitMode = "Rail", EstimatedTransitDaysMin = 15, EstimatedTransitDaysMax = 25, SupportsConsolidation = true }
            );

            modelBuilder.Entity<ShippingRateTier>().HasData(
                // For Rule 1003 (Air Freight)
                new ShippingRateTier { Id = 1, ShippingRateRuleId = 1003, MinValue = 0, MaxValue = 100, TierUnit = "Kg", RatePerUnit = 20m, FixedTierCost = 0 },
                new ShippingRateTier { Id = 2, ShippingRateRuleId = 1003, MinValue = 100.01m, MaxValue = 300, TierUnit = "Kg", RatePerUnit = 15m, FixedTierCost = 50m },
                // For Rule 1007 (Domestic US - Standard Freight)
                new ShippingRateTier { Id = 3, ShippingRateRuleId = 1007, MinValue = 10, MaxValue = 100, TierUnit = "Kg", RatePerUnit = 0.7m, FixedTierCost = 0 },
                new ShippingRateTier { Id = 4, ShippingRateRuleId = 1007, MinValue = 100.01m, MaxValue = 500, TierUnit = "Kg", RatePerUnit = 0.5m, FixedTierCost = 20m }
            );

            modelBuilder.Entity<Warehouse>().HasData(
                new Warehouse { Id = 1, Name = "US West Coast Hub", Address1 = "1000 Logistics Way", City = "Los Angeles", StateProvince = "CA", ZipCode = "90001", CountryCode = "US", Latitude = 34.0522, Longitude = -118.2437, RegionId = 1, IsPrimaryWarehouseForRegion = true },
                new Warehouse { Id = 2, Name = "Vietnam Central Depot", Address1 = "50 Cong Hoa", City = "Ho Chi Minh City", StateProvince = "SG", ZipCode = "70000", CountryCode = "VN", Latitude = 10.762622, Longitude = 106.660172, RegionId = 2, IsPrimaryWarehouseForRegion = true }, // Updated with HCMC coords
                new Warehouse { Id = 3, Name = "UK Midlands Distribution", Address1 = "1 Distribution Park", City = "Birmingham", StateProvince = "ENG", ZipCode = "B1 1AA", CountryCode = "GB", Latitude = 52.4862, Longitude = -1.8904, RegionId = 3, IsPrimaryWarehouseForRegion = true },
                new Warehouse { Id = 4, Name = "Singapore Main Warehouse", Address1 = "1 Tuas Link", City = "Singapore", StateProvince = "", ZipCode = "638596", CountryCode = "SG", Latitude = 1.3521, Longitude = 103.8198, RegionId = 4, IsPrimaryWarehouseForRegion = true },
                new Warehouse { Id = 5, Name = "China Shanghai Logistics", Address1 = "888 Logistics Road", City = "Shanghai", StateProvince = "SH", ZipCode = "200000", CountryCode = "CN", Latitude = 31.2304, Longitude = 121.4737, RegionId = 5, IsPrimaryWarehouseForRegion = true },
                new Warehouse { Id = 6, Name = "Russia Moscow Hub", Address1 = "1 Kremlin St", City = "Moscow", StateProvince = "", ZipCode = "101000", CountryCode = "RU", Latitude = 55.7558, Longitude = 37.6173, RegionId = 6, IsPrimaryWarehouseForRegion = true },
                new Warehouse { Id = 7, Name = "Indonesia Jakarta Depot", Address1 = "1 Sudirman Rd", City = "Jakarta", StateProvince = "JK", ZipCode = "10220", CountryCode = "ID", Latitude = -6.2088, Longitude = 106.8456, RegionId = 7, IsPrimaryWarehouseForRegion = true }
            );

            modelBuilder.Entity<ShippingRateRule>().HasData(
                // Rule A: International Standard Ocean Freight - VN to US (Port-to-Port) for Large Furniture
                new ShippingRateRule
                {
                    Id = 1001,
                    RuleName = "Ocean Freight VN to US - Large Furniture (Port-to-Port)",
                    IsActive = true,
                    OriginShippingZoneId = 101,
                    DestinationShippingZoneId = 102,
                    ShippingServiceLevelId = 1,
                    ProductShippingProfileId = 201,
                    GlobalShippingLaneId = 1,
                    BaseRate = 500m,
                    RatePerCbm = 150m,
                    MinApplicableCbm = 0.5m,
                    MaxApplicableCbm = 10m,
                    MinOrderValue = 0,
                    MaxOrderValue = 4999m,
                    FlatSurcharge = 50m,
                    SurchargeReason = "Customs Admin Fee"
                },
                // Rule B: Last-mile White Glove Delivery - US West Coast Freight Hub to LA Metro Area
                new ShippingRateRule
                {
                    Id = 1002,
                    RuleName = "LA Metro White Glove Delivery - Large Furniture",
                    IsActive = true,
                    OriginShippingZoneId = 102,
                    DestinationShippingZoneId = 103,
                    ShippingServiceLevelId = 2,
                    ProductShippingProfileId = 201,
                    BaseRate = 250m,
                    RatePerItem = 50m,
                    ApplyFloorSurcharge = true,
                    MinFloorForSurcharge = 2,
                    SurchargePerFloor = 25m,
                    SurchargeReason = "Inside Delivery & Assembly"
                },
                // Rule C: International Air Freight (Expedited) - VN to US (Port-to-Port)
                new ShippingRateRule
                {
                    Id = 1003,
                    RuleName = "Air Freight VN to US - Large Furniture (Expedited)",
                    IsActive = true,
                    OriginShippingZoneId = 101,
                    DestinationShippingZoneId = 102,
                    ShippingServiceLevelId = 3,
                    ProductShippingProfileId = 201,
                    GlobalShippingLaneId = 2,
                    BaseRate = 1200m,
                    RatePerKg = 15m,
                    MinApplicableWeightKg = 0,
                    MaxApplicableWeightKg = 500m,
                    SurchargeReason = "Air Fuel Surcharge"
                },
                // Rule D: Free Shipping Threshold for International Freight (Example)
                new ShippingRateRule
                {
                    Id = 1004,
                    RuleName = "International Freight Free Shipping > $5000 (VN to US)",
                    IsActive = true,
                    OriginShippingZoneId = 101,
                    DestinationShippingZoneId = 102,
                    ShippingServiceLevelId = 1,
                    ProductShippingProfileId = null,
                    BaseRate = 0m,
                    RatePerCbm = 0m,
                    IsFreeShippingThreshold = true,
                    FreeShippingMinOrderValue = 5000m
                },
                // Rule E: Domestic Freight within Vietnam (South to North)
                new ShippingRateRule
                {
                    Id = 1005,
                    RuleName = "Domestic Freight VN South to North",
                    IsActive = true,
                    OriginShippingZoneId = 104,
                    DestinationShippingZoneId = 105,
                    ShippingServiceLevelId = 4,
                    ProductShippingProfileId = null,
                    BaseRate = 300000m,
                    RatePerCbm = 100000m,
                    MinApplicableCbm = 0.1m,
                    MaxApplicableCbm = 5m,
                    MinOrderValue = 0
                },
                // Rule F: International Ocean Freight - CN to US (Port-to-Port) for Large Furniture
                new ShippingRateRule
                {
                    Id = 1006,
                    RuleName = "Ocean Freight CN to US - Large Furniture",
                    IsActive = true,
                    OriginShippingZoneId = 108,
                    DestinationShippingZoneId = 102,
                    ShippingServiceLevelId = 1,
                    ProductShippingProfileId = 201,
                    GlobalShippingLaneId = 4,
                    BaseRate = 450m,
                    RatePerCbm = 140m,
                    MinApplicableCbm = 0.5m,
                    MaxApplicableCbm = 10m,
                    FlatSurcharge = 45m,
                    SurchargeReason = "Customs Handling CN"
                },
                // Rule G: Domestic Delivery in US from LA Hub (Standard Freight)
                new ShippingRateRule
                {
                    Id = 1007,
                    RuleName = "Domestic US - From LA Hub (Standard)",
                    IsActive = true,
                    OriginShippingZoneId = 103,
                    DestinationShippingZoneId = 103,
                    ShippingServiceLevelId = 5,
                    ProductShippingProfileId = null,
                    BaseRate = 100m,
                    RatePerKg = 0.5m,
                    MinApplicableWeightKg = 10,
                    MaxApplicableWeightKg = 500m,
                    IsRuralAreaSurcharge = true,
                    RuralAreaSurchargeAmount = 50m
                },
                // Rule H: Domestic Delivery in US from LA Hub (White Glove)
                new ShippingRateRule
                {
                    Id = 1008,
                    RuleName = "Domestic US - From LA Hub (White Glove)",
                    IsActive = true,
                    OriginShippingZoneId = 103,
                    DestinationShippingZoneId = 103,
                    ShippingServiceLevelId = 2, // Reusing ID 2 for White Glove
                    ProductShippingProfileId = 201,
                    BaseRate = 200m,
                    RatePerItem = 40m,
                    ApplyFloorSurcharge = true,
                    MinFloorForSurcharge = 2,
                    SurchargePerFloor = 20m
                },
                // Rule I: International Freight from SG to ID (Ocean)
                new ShippingRateRule
                {
                    Id = 1009,
                    RuleName = "Ocean Freight SG to ID",
                    IsActive = true,
                    OriginShippingZoneId = 111,
                    DestinationShippingZoneId = 110,
                    ShippingServiceLevelId = 1,
                    ProductShippingProfileId = 201,
                    GlobalShippingLaneId = 6,
                    BaseRate = 150m,
                    RatePerCbm = 50m,
                    MinApplicableCbm = 0.1m,
                    MaxApplicableCbm = 5m
                },
                // Rule J: Domestic Delivery in ID from Jakarta Hub (White Glove)
                new ShippingRateRule
                {
                    Id = 1010,
                    RuleName = "Domestic ID - From Jakarta (White Glove)",
                    IsActive = true,
                    OriginShippingZoneId = 110,
                    DestinationShippingZoneId = 110,
                    ShippingServiceLevelId = 6,
                    ProductShippingProfileId = 201,
                    BaseRate = 100m,
                    RatePerItem = 20m,
                    ApplyFloorSurcharge = true,
                    MinFloorForSurcharge = 3,
                    SurchargePerFloor = 10m
                },
                // Rule K: Rail Freight CN to Russia
                new ShippingRateRule
                {
                    Id = 1011,
                    RuleName = "Rail Freight CN to Russia",
                    IsActive = true,
                    OriginShippingZoneId = 108,
                    DestinationShippingZoneId = 109,
                    ShippingServiceLevelId = 7,
                    ProductShippingProfileId = 201,
                    GlobalShippingLaneId = 7,
                    BaseRate = 800m,
                    RatePerKg = 8m,
                    MinApplicableWeightKg = 50m,
                    MaxApplicableWeightKg = 1000m,
                    FlatSurcharge = 100m,
                    SurchargeReason = "Russia Customs"
                },
                // Rule L: Domestic Delivery in Russia from Moscow Hub (Standard)
                new ShippingRateRule
                {
                    Id = 1012,
                    RuleName = "Domestic RU - From Moscow (Standard)",
                    IsActive = true,
                    OriginShippingZoneId = 109,
                    DestinationShippingZoneId = 109,
                    ShippingServiceLevelId = 5,
                    ProductShippingProfileId = null,
                    BaseRate = 50m,
                    RatePerKg = 0.8m,
                    MinApplicableWeightKg = 5,
                    MaxApplicableWeightKg = 300m,
                    IsRuralAreaSurcharge = true,
                    RuralAreaSurchargeAmount = 30m
                }
            );

            modelBuilder.Entity<Language>().HasData(
                new Language { Id = 1, Name = "English - EN", Code = "en", IsDefault  = true },
                new Language { Id = 2, Name = "Vietnamese - VN", Code = "vi", IsDefault = false },
                new Language { Id = 3, Name = "中文 (简体) - ZH", Code = "zh", IsDefault = false }
           );

            modelBuilder.Entity<Finish>().HasData(
                new Finish { Id = 1, Name = "Matte Walnut", Code = "MAT-WAL" },
                new Finish { Id = 2, Name = "Glossy Oak", Code = "GL-OAK" }
            );

            modelBuilder.Entity<UPHFabric>().HasData(
                new UPHFabric { Id = 1, Fabric = "1020-01", IsCustom = false },
                new UPHFabric { Id = 2, Fabric = "1020-28", IsCustom = false },
                new UPHFabric { Id = 3, Fabric = "1025-01", IsCustom = true, CustomPrice = 199.99m }
            );

            modelBuilder.Entity<ProductVariantFabric>().HasData(
                new { ProductVariantId = 1, FabricId = 1 },
                new { ProductVariantId = 1, FabricId = 3 } // Custom Blue
            );

            modelBuilder.Entity<ProductVariantFabricImage>().HasData(
               new ProductVariantFabricImage { Id = 1, ProductVariantId = 1, FabricId = 1, ImageUrl = "https://theodorealexander.sirv.com/website/Frontend/Live/assests/fabric/8-200.jpg", IsPrimary = true },
               new ProductVariantFabricImage { Id = 2, ProductVariantId = 1, FabricId = 1, ImageUrl = "https://theodorealexander.sirv.com/website/Frontend/Live/assests/fabric/9-225.jpg", IsPrimary = false },
               new ProductVariantFabricImage { Id = 3, ProductVariantId = 1, FabricId = 3, ImageUrl = "https://theodorealexander.sirv.com/website/Frontend/Live/assests/fabric/9-246.jpg", IsPrimary = true }
           );

            modelBuilder.Entity<ProductVariantFinish>().HasData(
                new { ProductVariantId = 1, FinishId = 1 },
                new { ProductVariantId = 1, FinishId = 2 }
            );

            modelBuilder.Entity<ProductVariantFinishImage>().HasData(
                new ProductVariantFinishImage { Id = 1, ProductVariantId = 1, FinishId = 1, ImageUrl = "https://theodorealexander.sirv.com/website/Frontend/Live/assests/finish/Athenaeum.jpg", IsPrimary = true },
                new ProductVariantFinishImage { Id = 2, ProductVariantId = 1, FinishId = 1, ImageUrl = "https://theodorealexander.sirv.com/website/Frontend/Live/assests/finish/Cadet.jpg", IsPrimary = false },
                new ProductVariantFinishImage { Id = 3, ProductVariantId = 1, FinishId = 2, ImageUrl = "https://theodorealexander.sirv.com/website/Frontend/Live/assests/finish/9020-72.jpg", IsPrimary = true }
            );

            modelBuilder.Entity<ProductOption>().HasData(
                new ProductOption { Id = 1, Name = "Color"},
                new ProductOption { Id = 2, Name = "Size" }
            );

            modelBuilder.Entity<ProductOptionValue>().HasData(
                new ProductOptionValue { Id = 1, ProductOptionId = 1, Value = "Deep Black" },
                new ProductOptionValue { Id = 2, ProductOptionId = 1, Value = "White" },
                new ProductOptionValue { Id = 3, ProductOptionId = 1, Value = "Oak" },
                // Color (ProductOptionId = 1)
                new ProductOptionValue { Id = 7, ProductOptionId = 1, Value = "Walnut" },

                new ProductOptionValue { Id = 4, ProductOptionId = 2, Value = "36x12x40" },
                new ProductOptionValue { Id = 5, ProductOptionId = 2, Value = "42x16x48" },
                new ProductOptionValue { Id = 6, ProductOptionId = 2, Value = "48x18x52" },

                // Size (ProductOptionId = 2)
                new ProductOptionValue { Id = 8, ProductOptionId = 2, Value = "180x100x75" },
                new ProductOptionValue { Id = 9, ProductOptionId = 2, Value = "220x100x75" }
            );

            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant { Id = 1, ProductId = 1, Sku = "BLK-36", PriceAdjustment = 49.99m },
                new ProductVariant { Id = 2, ProductId = 1, Sku = "BLK-42", PriceAdjustment = 54.99m },
                new ProductVariant { Id = 3, ProductId = 1, Sku = "WHT-36", PriceAdjustment = 59.99m },
                new ProductVariant { Id = 4, ProductId = 1, Sku = "OAK-42", PriceAdjustment = 64.99m },
                new ProductVariant { Id = 5, ProductId = 1, Sku = "OAK-52", PriceAdjustment = 69.99m },
                new ProductVariant { Id = 6, ProductId = 2, Sku = "MAR-OAK-180", PriceAdjustment = 79.99m },
                new ProductVariant { Id = 7, ProductId = 2, Sku = "MAR-OAK-220", PriceAdjustment = 89.99m },
                new ProductVariant { Id = 8, ProductId = 2, Sku = "MAR-WAL-220", PriceAdjustment = 94.99m },
                new ProductVariant { Id = 10, ProductId = 1, Sku = "VCF1798", PriceAdjustment = 99.99m }
            );

            modelBuilder.Entity<ProductVariantOptionValue>().HasData(
                new { ProductVariantId = 1, ProductOptionValueId = 1 }, // Deep Black
                new { ProductVariantId = 1, ProductOptionValueId = 4 }, // 36x12x40

                new { ProductVariantId = 2, ProductOptionValueId = 1 }, // Deep Black
                new { ProductVariantId = 2, ProductOptionValueId = 5 }, // 42x16x48

                new { ProductVariantId = 3, ProductOptionValueId = 2 }, // White
                new { ProductVariantId = 3, ProductOptionValueId = 4 }, // 36x12x40

                new { ProductVariantId = 4, ProductOptionValueId = 3 }, // Oak
                new { ProductVariantId = 4, ProductOptionValueId = 5 }, // 42x16x48

                new { ProductVariantId = 5, ProductOptionValueId = 3 }, // Oak  
                new { ProductVariantId = 5, ProductOptionValueId = 6 }, // 48x18x52

                new { ProductVariantId = 6, ProductOptionValueId = 3 }, // Oak
                new { ProductVariantId = 6, ProductOptionValueId = 8 }, // 180x100x75

                new { ProductVariantId = 7, ProductOptionValueId = 3 }, // Oak
                new { ProductVariantId = 7, ProductOptionValueId = 9 }, // 220x100x75

                new { ProductVariantId = 8, ProductOptionValueId = 7 }, // Walnut
                new { ProductVariantId = 8, ProductOptionValueId = 9 } // 220x100x75
            );

            modelBuilder.Entity<ProductImage>().HasData(
                // Variant 1 - Deep Black - 36x12x40
                new ProductImage { Id = 1, ProductVariantId = 1, ImageUrl = "/images/blk_36_1.jpg", IsPrimary = true },
                new ProductImage { Id = 2, ProductVariantId = 1, ImageUrl = "/images/blk_36_2.jpg", IsPrimary = false },
                new ProductImage { Id = 3, ProductVariantId = 1, ImageUrl = "/images/blk_36_3.jpg", IsPrimary = false },

                // Variant 2 - Deep Black - 42x16x48
                new ProductImage { Id = 4, ProductVariantId = 2, ImageUrl = "/images/blk_42_1.jpg", IsPrimary = true },
                new ProductImage { Id = 5, ProductVariantId = 2, ImageUrl = "/images/blk_42_2.jpg", IsPrimary = false },

                // Variant 3 - White - 36x12x40
                new ProductImage { Id = 6, ProductVariantId = 3, ImageUrl = "/images/wht_36_1.jpg", IsPrimary = true },
                new ProductImage { Id = 7, ProductVariantId = 3, ImageUrl = "/images/wht_36_2.jpg", IsPrimary = false },

                // Variant 4 - Oak - 42x16x48
                new ProductImage { Id = 8, ProductVariantId = 4, ImageUrl = "/images/oak_42_1.jpg", IsPrimary = true },
                new ProductImage { Id = 9, ProductVariantId = 4, ImageUrl = "/images/oak_42_2.jpg", IsPrimary = false },

                // Variant 5 - Oak - 48x18x52
                new ProductImage { Id = 10, ProductVariantId = 5, ImageUrl = "/images/oak_52_1.jpg", IsPrimary = true },
                new ProductImage { Id = 11, ProductVariantId = 5, ImageUrl = "/images/oak_52_2.jpg", IsPrimary = false },
                new ProductImage { Id = 12, ProductVariantId = 5, ImageUrl = "/images/oak_52_3.jpg", IsPrimary = false },

                new ProductImage { Id = 13, ProductVariantId = 6, ImageUrl = "/images/mar_oak_180_1.jpg", IsPrimary = true },
                new ProductImage { Id = 14, ProductVariantId = 6, ImageUrl = "/images/mar_oak_180_2.jpg", IsPrimary = false },

                new ProductImage { Id = 15, ProductVariantId = 7, ImageUrl = "/images/mar_oak_220_1.jpg", IsPrimary = true },
                new ProductImage { Id = 16, ProductVariantId = 7, ImageUrl = "/images/mar_oak_220_2.jpg", IsPrimary = false },

                new ProductImage { Id = 17, ProductVariantId = 8, ImageUrl = "/images/mar_wal_220_1.jpg", IsPrimary = true },
                new ProductImage { Id = 18, ProductVariantId = 8, ImageUrl = "/images/mar_wal_220_2.jpg", IsPrimary = false }
            );


            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, CollectionId = 8, RoomId = 2, TypeId = 4, LifeStyleId = 4, StyleId = 9, Sku = "TA54027.C301", Slug = "catalina-round-dining-table-ta54027-c301", Name = "Catalina Round Dining Table", NetWeightKg = 91m, Depth = 162.6m, Width = 162.6m, Height = 76.2m, ProductCategoryId = 101, ProductShippingProfileId = 201, DefaultImageUrl = "https://theodorealexander.sirv.com/ProductphotoCrop/TA5/TA54027.C301_main_1.jpg" },
                new Product { Id = 2, CollectionId = 8, RoomId = 1, TypeId = 29, LifeStyleId = 4, StyleId = 9,Sku = "TA51059.C301", Slug = "catalina-cocktail-table-ta51059-c301", Name = "Catalina Cocktail Table", NetWeightKg = 38m, Depth = 71.1m, Width = 122m, Height = 41.9m, ProductCategoryId = 102, ProductShippingProfileId = 202, DefaultImageUrl = "https://theodorealexander.sirv.com/ProductphotoCrop/TA5/TA51059.C301_main_1.jpg" },
                new Product { Id = 3, CollectionId = 8, RoomId = 3, TypeId = 20, LifeStyleId = 4, StyleId = 9, Sku = "TA84012.C306", Slug = "catalina-upholstered-california-king-bed-ta84012-c306", Name = "Designer Vase", NetWeightKg = 2m, Depth = 30m, Width = 20m, Height = 20m, ProductCategoryId = 103, ProductShippingProfileId = 203, DefaultImageUrl = "https://theodorealexander.sirv.com/ProductphotoCrop/TA8/TA84012.C306_main_1.jpg" }
            );

            modelBuilder.Entity<ProductRegionAvailability>().HasData(
                // Product 1 (Dining Table) available in US, VN, UK, SG, CN, RU, ID
                new ProductRegionAvailability { Id = 1, ProductId = 1, RegionId = 1 }, // US
                new ProductRegionAvailability { Id = 2, ProductId = 1, RegionId = 2 }, // VN
                new ProductRegionAvailability { Id = 3, ProductId = 1, RegionId = 3 }, // UK
                new ProductRegionAvailability { Id = 4, ProductId = 1, RegionId = 4 }, // SG
                new ProductRegionAvailability { Id = 5, ProductId = 1, RegionId = 5 }, // CN
                new ProductRegionAvailability { Id = 6, ProductId = 1, RegionId = 6 }, // RU
                new ProductRegionAvailability { Id = 7, ProductId = 1, RegionId = 7 }, // ID

                // Product 2 (Cocktail Table) available in US, VN, UK, SG
                new ProductRegionAvailability { Id = 8, ProductId = 2, RegionId = 1 }, // US
                new ProductRegionAvailability { Id = 9, ProductId = 2, RegionId = 2 }, // VN
                new ProductRegionAvailability { Id = 10, ProductId = 2, RegionId = 3 }, // UK
                new ProductRegionAvailability { Id = 11, ProductId = 2, RegionId = 4 }, // SG

                // Product 3 (Designer Vase) available in all regions
                new ProductRegionAvailability { Id = 12, ProductId = 3, RegionId = 1 }, // US
                new ProductRegionAvailability { Id = 13, ProductId = 3, RegionId = 2 }, // VN
                new ProductRegionAvailability { Id = 14, ProductId = 3, RegionId = 3 }, // UK
                new ProductRegionAvailability { Id = 15, ProductId = 3, RegionId = 4 }, // SG
                new ProductRegionAvailability { Id = 16, ProductId = 3, RegionId = 5 }, // CN
                new ProductRegionAvailability { Id = 17, ProductId = 3, RegionId = 6 }, // RU
                new ProductRegionAvailability { Id = 18, ProductId = 3, RegionId = 7 }  // ID
            );

            modelBuilder.Entity<ProductCategory>().HasData(
                new ProductCategory { Id = 101, Name = "Large Furniture", IsBulky = true, RequiresAssembly = true, IsFragile = false, DefaultDimensionalFactor = 6000 },
                new ProductCategory { Id = 102, Name = "Medium Furniture", IsBulky = true, RequiresAssembly = false, IsFragile = false, DefaultDimensionalFactor = 5000 },
                new ProductCategory { Id = 103, Name = "Decor Items", IsBulky = false, RequiresAssembly = false, IsFragile = true, DefaultDimensionalFactor = 4000 }
            );

            modelBuilder.Entity<ProductShippingProfile>().HasData(
                new ProductShippingProfile { Id = 201, Name = "Dining Table (Freight)", Description = "Requires freight shipping, often palletized", IsBulky = true, RequiresPallet = true, RequiresSpecialEquipment = true, DefaultDimensionalFactor = 6000 },
                new ProductShippingProfile { Id = 202, Name = "Cocktail Table (Freight/Parcel)", Description = "Can be shipped as large parcel or small freight", IsBulky = false, RequiresPallet = false, RequiresSpecialEquipment = false, DefaultDimensionalFactor = 5000 },
                new ProductShippingProfile { Id = 203, Name = "Standard Parcel", Description = "Small, non-bulky items, suitable for courier", IsBulky = false, RequiresPallet = false, RequiresSpecialEquipment = false, DefaultDimensionalFactor = 4000 }
            );

            modelBuilder.Entity<InventoryItem>().HasData(
                new InventoryItem { Id = 1, ProductId = 1, WarehouseId = 1, QuantityOnHand = 50, QuantityReserved = 10, MinimumStockLevel = 5 }, // Dining Table in HCMC (VN)
                new InventoryItem { Id = 2, ProductId = 2, WarehouseId = 1, QuantityOnHand = 100, QuantityReserved = 20, MinimumStockLevel = 10 }, // Coffee Table in HCMC (VN)
                new InventoryItem { Id = 3, ProductId = 1, WarehouseId = 3, QuantityOnHand = 30, QuantityReserved = 5, MinimumStockLevel = 3 }, // Dining Table in LA (US)
                new InventoryItem { Id = 4, ProductId = 2, WarehouseId = 3, QuantityOnHand = 70, QuantityReserved = 15, MinimumStockLevel = 7 }, // Coffee Table in LA (US)
                new InventoryItem { Id = 5, ProductId = 1, WarehouseId = 4, QuantityOnHand = 15, QuantityReserved = 3, MinimumStockLevel = 2 }, // Dining Table in SG
                new InventoryItem { Id = 6, ProductId = 2, WarehouseId = 4, QuantityOnHand = 40, QuantityReserved = 8, MinimumStockLevel = 5 }, // Coffee Table in SG
                new InventoryItem { Id = 7, ProductId = 1, WarehouseId = 2, QuantityOnHand = 80, QuantityReserved = 15, MinimumStockLevel = 10 }, // Dining Table in Shenzhen (CN) - Export Hub
                new InventoryItem { Id = 8, ProductId = 2, WarehouseId = 2, QuantityOnHand = 120, QuantityReserved = 25, MinimumStockLevel = 15 }, // Coffee Table in Shenzhen (CN) - Export Hub
                new InventoryItem { Id = 9, ProductId = 3, WarehouseId = 1, QuantityOnHand = 200, QuantityReserved = 50, MinimumStockLevel = 20 }, // Vase in HCMC (VN)
                new InventoryItem { Id = 10, ProductId = 3, WarehouseId = 3, QuantityOnHand = 150, QuantityReserved = 30, MinimumStockLevel = 15 }, // Vase in LA (US)
                new InventoryItem { Id = 11, ProductId = 1, WarehouseId = 5, QuantityOnHand = 10, QuantityReserved = 1, MinimumStockLevel = 1 }, // Dining Table in Moscow (RU)
                new InventoryItem { Id = 12, ProductId = 2, WarehouseId = 6, QuantityOnHand = 25, QuantityReserved = 5, MinimumStockLevel = 3 }  // Coffee Table in Jakarta (ID)
            );

            // ProductPrices Seed Data (NEW)
            modelBuilder.Entity<ProductPrice>().HasData(
                // Dining Table (ID = 1)
                new ProductPrice { Id = 1, ProductId = 1, RegionId = 1, Price = 1800.00m, Currency = "USD", EffectiveDate = DateTime.Parse("2025-01-01") }, // US
                new ProductPrice { Id = 2, ProductId = 1, RegionId = 2, Price = 38000000.00m, Currency = "VND", EffectiveDate = DateTime.Parse("2025-01-01") }, // VN
                new ProductPrice { Id = 3, ProductId = 1, RegionId = 3, Price = 1500.00m, Currency = "GBP", EffectiveDate = DateTime.Parse("2025-01-01") }, // UK
                new ProductPrice { Id = 4, ProductId = 1, RegionId = 4, Price = 2500.00m, Currency = "SGD", EffectiveDate = DateTime.Parse("2025-01-01") }, // SG
                new ProductPrice { Id = 5, ProductId = 1, RegionId = 5, Price = 13000.00m, Currency = "CNY", EffectiveDate = DateTime.Parse("2025-01-01") }, // CN
                new ProductPrice { Id = 6, ProductId = 1, RegionId = 6, Price = 160000.00m, Currency = "RUB", EffectiveDate = DateTime.Parse("2025-01-01") }, // RU
                new ProductPrice { Id = 7, ProductId = 1, RegionId = 7, Price = 28000000.00m, Currency = "IDR", EffectiveDate = DateTime.Parse("2025-01-01") }, // ID

                // Coffee Table (ID = 2)
                new ProductPrice { Id = 8, ProductId = 2, RegionId = 1, Price = 550.00m, Currency = "USD", EffectiveDate = DateTime.Parse("2025-01-01") }, // US
                new ProductPrice { Id = 9, ProductId = 2, RegionId = 2, Price = 12000000.00m, Currency = "VND", EffectiveDate = DateTime.Parse("2025-01-01") }, // VN
                new ProductPrice { Id = 10, ProductId = 2, RegionId = 3, Price = 450.00m, Currency = "GBP", EffectiveDate = DateTime.Parse("2025-01-01") }, // UK
                new ProductPrice { Id = 11, ProductId = 2, RegionId = 4, Price = 700.00m, Currency = "SGD", EffectiveDate = DateTime.Parse("2025-01-01") }, // SG
                new ProductPrice { Id = 12, ProductId = 2, RegionId = 5, Price = 3800.00m, Currency = "CNY", EffectiveDate = DateTime.Parse("2025-01-01") }, // CN
                new ProductPrice { Id = 13, ProductId = 2, RegionId = 6, Price = 45000.00m, Currency = "RUB", EffectiveDate = DateTime.Parse("2025-01-01") }, // RU
                new ProductPrice { Id = 14, ProductId = 2, RegionId = 7, Price = 8000000.00m, Currency = "IDR", EffectiveDate = DateTime.Parse("2025-01-01") }, // ID

                // Designer Vase (ID = 3)
                new ProductPrice { Id = 15, ProductId = 3, RegionId = 1, Price = 120.00m, Currency = "USD", EffectiveDate = DateTime.Parse("2025-01-01") }, // US
                new ProductPrice { Id = 16, ProductId = 3, RegionId = 2, Price = 2500000.00m, Currency = "VND", EffectiveDate = DateTime.Parse("2025-01-01") }, // VN
                new ProductPrice { Id = 17, ProductId = 3, RegionId = 3, Price = 90.00m, Currency = "GBP", EffectiveDate = DateTime.Parse("2025-01-01") }, // UK
                new ProductPrice { Id = 18, ProductId = 3, RegionId = 4, Price = 160.00m, Currency = "SGD", EffectiveDate = DateTime.Parse("2025-01-01") }, // SG
                new ProductPrice { Id = 19, ProductId = 3, RegionId = 5, Price = 800.00m, Currency = "CNY", EffectiveDate = DateTime.Parse("2025-01-01") }, // CN
                new ProductPrice { Id = 20, ProductId = 3, RegionId = 6, Price = 9000.00m, Currency = "RUB", EffectiveDate = DateTime.Parse("2025-01-01") }, // RU
                new ProductPrice { Id = 21, ProductId = 3, RegionId = 7, Price = 1500000.00m, Currency = "IDR", EffectiveDate = DateTime.Parse("2025-01-01") }  // ID
            );
        }
    }
}
