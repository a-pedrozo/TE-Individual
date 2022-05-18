﻿namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch?
            */

            // ### EXAMPLE:
            int initialNumberOfBirds = 4;
            int birdsThatFlewAway = 1;
            int remainingNumberOfBirds = initialNumberOfBirds - birdsThatFlewAway;

            /*
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests?
            */

            // ### EXAMPLE:
            int numberOfBirds = 6;
            int numberOfNests = 3;
            int numberOfExtraBirds = numberOfBirds - numberOfNests;



            /*
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods?
            */
            int numRacoons = 3;
            int numRacoonsLeave = 2;
            int numRacoonWoods = numRacoons - numRacoonsLeave;
            /*
            4. There are 5 flowers and 3 bees. How many less bees than flowers?
            */
            int flowers = 5;
            int bees = 3;
            int lessBees = flowers - bees;
            /*
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now?
            */
            int lonelyPidgeon = 1;
            int anotherPidgeon = 1;
            int totalPidgeons = lonelyPidgeon + anotherPidgeon;
            /*
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now?
            */
            int owlsOnFence = 3;
            int owlsJoined = 2;
            int totalOwls = owlsOnFence + owlsJoined;
            /*
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home?
            */
            int workingBeavers = 2;
            int swimmingBeavers = 1;
            int totalWorkingBeavers = workingBeavers - swimmingBeavers;
            /*
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all?
            */
            int treeToucans = 2;
            int oneToucan = 1;
            int totalToucans = treeToucans + oneToucan;
            /*
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts?
            */
            int squirrels = 4;
            int nuts = 2;
            int difference = squirrels - nuts;
            /*
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find?
            */
            decimal quater = 0.25m;
            decimal dime = 0.10m;
            decimal nickles = 0.10m;
            decimal total = quater + dime + nickles;

            /*
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all?
            */
            int breirMuffins = 18;
            int macadamsMuffins = 20;
            int flanneryMuffins = 17;
            int hiltFirstGradeMuffins = breirMuffins + macadamsMuffins + flanneryMuffins;
            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */
            double yoyo = 0.24;
            double whistle = 0.14;
            double toyTotalAmmount = yoyo + whistle;
            /*
            13. Mrs. Hilt made 5 Rice Krispies Treats. She used 8 large marshmallows
            and 10 mini marshmallows. How many marshmallows did she use
            altogether?
            */
            int largeMarshmallows = 8;
            int miniMarhmallows = 10;
            int totalMarshmallows = largeMarshmallows + miniMarhmallows;
            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */
            int hiltHouse = 29;
            int bredknockSchool = 17;
            int differenceSnow = hiltHouse - bredknockSchool;
            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */
            double totalCash = 10.00;
            double toyTruck = 3.00;
            double pencil = 2.00;
            double remainder = totalCash - toyTruck - pencil;
            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */
            int totalMarbles = 16;
            int lostMarbles = 7;
            int differenceMarbles = totalMarbles - lostMarbles;
            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */
            int meganSeashells = 19;
            int goalSeashells = 25;
            int differenceSeashells = goalSeashells - meganSeashells;

            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */
            int totalBalloons = 17;
            int redBalloons = 8;
            int greenBalloons = totalBalloons - redBalloons;
            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */
            int currentBookshelf = 38;
            int martaBooks = 10;
            int totalBooks = currentBookshelf + martaBooks;
            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */
            int beeLegs = 6;
            int beesAmmount = 8;
            int totalLegs = beeLegs * beesAmmount;
            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */
            double iceCreamCone = 0.99;
            double totalIceCreamCone = iceCreamCone * 2.0;
            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */
            int totalRocks = 125;
            int currentRocks = 64;
            int remainingRocks = totalRocks - currentRocks;
            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */
            int hiltMarbles = 38;
            int sheLostMarbles = 15;
            int remainingMarbles = hiltMarbles - sheLostMarbles;
            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */
            int concert = 78;
            int milesTraveled = 32;
            int milesLeft = concert - milesTraveled;

            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time (in minutes) did she spend shoveling snow?
            */
            int shoveledInTheMorning = 90;
            int shovledInTheAfternoon = 45;
            int shovledTotal = shoveledInTheMorning + shovledInTheAfternoon;
            /*
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */
            int hotDogsBought = 6;
            decimal hotDogCost = 0.50m;
            decimal totalCost = hotDogsBought * hotDogCost;
            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */
            decimal totalChange = 0.50m;
            decimal pencilCost = 0.07m;
            decimal totalPencils = totalChange / pencilCost;
            /*
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */
            int totalButterflies = 33;
            int orangeButterflies = 20;
            int redButterflies = totalButterflies - orangeButterflies;
            /*
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */
            decimal kateDollar = 1.00m;
            decimal candyCost = 0.54m;
            decimal kateChange = kateDollar - candyCost;
            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */
            int markTreesBackyard = 13;
            int markPlantsMore = 12;
            int markTotalTrees = markTreesBackyard + markPlantsMore;
            /*
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */
            int seeingGrandma = 2;
            int hoursToDays = 24;
            int hoursToSeeGrandma = seeingGrandma * hoursToDays;

            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */
            int cousins = 4;
            int gumPieces = 5;
            int gumTotal = cousins * gumPieces;
            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */
            decimal danWallet = 3.00m;
            decimal candyBarCost = 1.00m;
            decimal danWalletRemain = danWallet - candyBarCost;
            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */
            int boats = 5;
            int peopleInBoats = 3;
            int totalPeople = boats * peopleInBoats;
            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */
            int legoSet = 380;
            int legoPiecesLost = 57;
            int legoPiecesRemain = legoSet - legoPiecesLost;
            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */
            int arthurMuffins = 35;
            int muffinsWanted = 83;
            int muffinsDifference = muffinsWanted - arthurMuffins;
            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */
            int willyCrayons = 1400;
            int lucyCrayons = 290;
            int differenceCrayons = willyCrayons - lucyCrayons;
            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */
            int stickersPerPage = 10;
            int pagesOfStickers = 22;
            int totalStickers = stickersPerPage * pagesOfStickers;
            /*
            39. There are 100 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */
            int cupcakes = 100;
            int children = 8;
            int sharingCupcakes = cupcakes / children;
            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies, how many
            cookies will not be placed in a jar?
            */
            int gingerbreadCookies = 47;
            int glassJarsPer = 6;
            int cookiesLeftOver = gingerbreadCookies % glassJarsPer;
            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received an equal number of croissants,
            how many will be left with Marian?
            */
            int croissants = 59;
            int neighborsPer = 8;
            int croissatsLeftOver = croissants % neighborsPer;
            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */
            int cookiesTotal = 276;
            int cookiesPerTray = 12;
            int traysTotal = cookiesTotal / cookiesPerTray;
            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */
            int totalPretzels = 480;
            int servingsPerPretzels = 12;
            int totalServings = totalPretzels / servingsPerPretzels;
            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */
            int cupcakesTotal = 51;
            int cupcakesPerBox = 3;
            int cupcakeBoxTotal = cupcakesTotal / cupcakesPerBox;
            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */
            int carrotSticksTotal = 74;
            int carrotSticksPerPerson = 12;
            int carrotSticksRemaining = carrotSticksTotal % carrotSticksPerPerson;
            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */
            int totalTeddyBears = 98;
            int teddyBearPerShelf = 7;
            int shelfsFilled = totalTeddyBears / teddyBearPerShelf;
            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */
            int picturesTotal = 480;
            int picturePerAlbum = 20;
            int albumsTotal = picturesTotal / picturePerAlbum;
            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */
            int cardsTotal = 94;
            int cardsPerBox = 8;
            int boxesTotal = cardsTotal / cardsPerBox;
            int unfilledBoxes = cardsTotal % cardsPerBox;
            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */
            int susiesBooks = 210;
            int shelfs = 10;
            int booksPerShelf = susiesBooks / shelfs;

            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */
            int totalcroissants = 17;
            int guest = 7;
            int croissantsPerGuest = totalcroissants / guest;
            /*
            51. Bill and Jill are house painters. Bill can paint a 12 x 14 room in 2.15 hours, while Jill averages
            1.90 hours. How long will it take the two painters working together to paint 5 12 x 14 rooms?
            Hint: Calculate the hourly rate for each painter, combine them, and then divide the total walls in feet by the combined hourly rate of the painters.
            */

            /*
            52. Create and assign variables to hold a first name, last name, and middle initial. Using concatenation,
            build an additional variable to hold the full name in the order of last name, first name, middle initial. The
            last and first names should be separated by a comma followed by a space, and the middle initial must end
            with a period. Use "Grace", "Hopper, and "B" for the first name, last name, and middle initial.
            Example: "John", "Smith, "D" —> "Smith, John D."
            */
            string firstName = "Grace, ";
            string lastName = "Hopper, ";
            string middleInitial = "D.";
            string fullName = lastName + firstName + middleInitial;
            /*
            53. The distance between New York and Chicago is 800 miles, and the train has already travelled 537 miles.
            What percentage of the trip as a whole number (integer) has been completed?
            */
            int totalMiles = 800;
            int milesRode = 537;
            int percentOfTrip = milesRode / totalMiles;
        }
    }
}
