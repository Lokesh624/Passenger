using Microsoft.EntityFrameworkCore.Migrations;

namespace Passenger.Contract.Migrations
{
    public partial class insertMasterData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Country_Details",
                columns: new[] { "CountryID", "CountryName" },
                values: new object[] { 1, "India" });

            migrationBuilder.InsertData(
                table: "District_Details",
                columns: new[] { "DistrictID", "DistrictName", "StateID" },
                values: new object[,]
                {
                    { 448, "Patiala", 21 },
                    { 449, "Rupnagar", 21 },
                    { 450, "Sangrur", 21 },
                    { 451, "Sri_Muktsar_Sahib", 21 },
                    { 452, "Barnala", 21 },
                    { 453, "Faridkot", 21 },
                    { 454, "Fatehgarh_Sahib", 21 },
                    { 455, "Jalandhar", 21 },
                    { 456, "Ludhiana", 21 },
                    { 457, "Nawanshahr", 21 },
                    { 458, "Tarn_Taran", 21 },
                    { 459, "Ajmer", 22 },
                    { 460, "Alwar", 22 },
                    { 461, "Banswara", 22 },
                    { 462, "Baran", 22 },
                    { 463, "Barmer", 22 },
                    { 464, "Bharatpur", 22 },
                    { 447, "Pathankot", 21 },
                    { 465, "Bhilwara", 22 },
                    { 446, "Moga", 21 },
                    { 444, "Kapurthala", 21 },
                    { 427, "Malkangiri", 20 },
                    { 428, "Mayurbhanj", 20 },
                    { 429, "Nabarangapur", 20 },
                    { 430, "Nayagarh", 20 },
                    { 431, "Nuapada", 20 },
                    { 432, "Puri", 20 },
                    { 433, "Rayagada", 20 },
                    { 434, "Sambalpur", 20 },
                    { 435, "Sonapur", 20 },
                    { 436, "Sundergarh", 20 },
                    { 437, "Ajit Garh (SAS Nagar)", 21 },
                    { 438, "Amritsar", 21 },
                    { 439, "Bathinda", 21 },
                    { 440, "Fazilka", 21 },
                    { 441, "Ferozepur", 21 },
                    { 442, "Gurdaspur", 21 },
                    { 443, "Hoshiarpur", 21 },
                    { 445, "Mansa", 21 },
                    { 426, "Koraput", 20 },
                    { 466, "Bikaner", 22 },
                    { 468, "Chittorgarh", 22 },
                    { 490, "Tonk", 22 },
                    { 491, "Udaipur", 22 },
                    { 492, "East_Sikkim", 23 },
                    { 493, "North_Sikkim", 23 },
                    { 494, "South_Sikkim", 23 },
                    { 495, "West_Sikkim", 23 },
                    { 496, "Ariyalur", 24 },
                    { 497, "Chennai", 24 },
                    { 498, "Coimbatore", 24 },
                    { 499, "Cuddalore", 24 },
                    { 500, "Dharmapuri", 24 },
                    { 501, "Dindigul", 24 },
                    { 502, "Erode", 24 },
                    { 503, "Kancheepuram", 24 },
                    { 504, "Kanyakumari", 24 },
                    { 505, "Karur", 24 },
                    { 506, "Krishnagiri", 24 },
                    { 489, "Sirohi", 22 },
                    { 467, "Bundi", 22 },
                    { 488, "Sikar", 22 },
                    { 486, "Rajsamand", 22 },
                    { 469, "Churu", 22 },
                    { 470, "Dausa", 22 },
                    { 471, "Dholpur", 22 },
                    { 472, "Dungarpur", 22 },
                    { 473, "Ganganagar", 22 },
                    { 474, "Hanumangarh", 22 },
                    { 475, "Jaipur", 22 },
                    { 476, "Jaisalmer", 22 },
                    { 477, "Jalor", 22 },
                    { 478, "Jhalawar", 22 },
                    { 479, "Jhunjhunun", 22 },
                    { 480, "Jodhpur", 22 },
                    { 481, "Karauli", 22 },
                    { 482, "Kota", 22 },
                    { 483, "Nagaur", 22 },
                    { 484, "Pali", 22 },
                    { 485, "Pratapgarh", 22 },
                    { 487, "Sawai_Madhopur", 22 },
                    { 425, "Khorda", 20 },
                    { 424, "Kendujhar", 20 },
                    { 423, "Kendrapara", 20 },
                    { 363, "Sindhudurg", 15 },
                    { 364, "Solapur", 15 },
                    { 365, "Thane", 15 },
                    { 366, "Washim", 15 },
                    { 367, "Yavatmal", 15 },
                    { 368, "Bishnupur", 16 },
                    { 369, "Chandel", 16 },
                    { 370, "Churachandpur", 16 },
                    { 371, "Imphal_East", 16 },
                    { 372, "Imphal_West", 16 },
                    { 373, "Senapati", 16 },
                    { 374, "Tamenglong", 16 },
                    { 375, "Thoubal", 16 },
                    { 376, "Ukhrul", 16 },
                    { 377, "East Jaintia Hills", 17 },
                    { 378, "East_Garo_Hills", 17 },
                    { 379, "East_Khasi_Hills", 17 },
                    { 362, "Satara", 15 },
                    { 380, "North Garo Hills", 17 },
                    { 361, "Sangli", 15 },
                    { 359, "Raigarh(MH)", 15 },
                    { 341, "Dhule", 15 },
                    { 342, "Gadchiroli", 15 },
                    { 343, "Gondiya", 15 },
                    { 344, "Hingoli", 15 },
                    { 345, "Jalgaon", 15 },
                    { 346, "Jalna", 15 },
                    { 347, "Kolhapur", 15 },
                    { 348, "Latur", 15 },
                    { 349, "Mumbai", 15 },
                    { 350, "Mumbai Suburban", 15 },
                    { 351, "Nagpur", 15 },
                    { 352, "Nanded", 15 },
                    { 353, "Nandurbar", 15 },
                    { 354, "Nashik", 15 },
                    { 355, "Osmanabad", 15 },
                    { 357, "Parbhani", 15 },
                    { 358, "Pune", 15 },
                    { 360, "Ratnagiri", 15 },
                    { 381, "Ri_Bhoi", 17 },
                    { 382, "South West garo Hills", 17 },
                    { 383, "South West Khasi Hills", 17 },
                    { 406, "Zunheboto", 19 },
                    { 407, "Angul", 20 },
                    { 408, "Balangir", 20 },
                    { 409, "Baleswar", 20 },
                    { 410, "Bargarh", 20 },
                    { 411, "Bhadrak", 20 },
                    { 412, "Boudh", 20 },
                    { 413, "Cuttack", 20 },
                    { 414, "Debagarh", 20 },
                    { 415, "Dhenkanal", 20 },
                    { 416, "Gajapati", 20 },
                    { 417, "Ganjam", 20 },
                    { 418, "Jagatsinghapur", 20 },
                    { 419, "Jajapur", 20 },
                    { 420, "Jharsuguda", 20 },
                    { 421, "Kalahandi", 20 },
                    { 422, "Kandhamal", 20 },
                    { 405, "Wokha", 19 },
                    { 404, "Tuensang", 19 },
                    { 403, "Phek", 19 },
                    { 402, "Peren", 19 },
                    { 384, "South_Garo_Hills", 17 },
                    { 385, "West Jaintia_Hills", 17 },
                    { 386, "West_Garo_Hills", 17 },
                    { 387, "West_Khasi_Hills", 17 },
                    { 388, "Aizawl", 18 },
                    { 389, "Champhai", 18 },
                    { 390, "Kolasib", 18 },
                    { 391, "Lawngtlai", 18 },
                    { 507, "Madurai", 24 },
                    { 392, "Lunglei", 18 },
                    { 394, "Saiha", 18 },
                    { 395, "Serchhip", 18 },
                    { 396, "Dimapur", 19 },
                    { 397, "Kiphire", 19 },
                    { 398, "Kohima", 19 },
                    { 399, "Longleng", 19 },
                    { 400, "Mokokchung", 19 },
                    { 401, "Mon", 19 },
                    { 393, "Mammit", 18 },
                    { 508, "Nagapattinam", 24 },
                    { 509, "Namakkal", 24 },
                    { 510, "Nilgiris", 24 },
                    { 617, "Sonbhadra", 27 },
                    { 618, "Sultanpur", 27 },
                    { 619, "Unnao", 27 },
                    { 620, "Varanasi", 27 },
                    { 621, "Almora", 28 },
                    { 622, "Bageshwar", 28 },
                    { 623, "Chamoli", 28 },
                    { 624, "Champawat", 28 },
                    { 625, "Dehradun", 28 },
                    { 626, "Haridwar", 28 },
                    { 627, "Nainital", 28 },
                    { 628, "Pauri_Garhwal", 28 },
                    { 629, "Pithoragarh", 28 },
                    { 630, "Rudraprayag", 28 },
                    { 631, "Tehri_Garhwal", 28 },
                    { 632, "Udham_Singh_Nagar", 28 },
                    { 633, "Uttarkashi", 28 },
                    { 616, "Sitapur", 27 },
                    { 634, "Alipurduar", 29 },
                    { 615, "Siddharthnagar", 27 },
                    { 613, "Shamli", 27 },
                    { 596, "Mahoba", 27 },
                    { 597, "Mainpuri", 27 },
                    { 598, "Mathura", 27 },
                    { 599, "Mau", 27 },
                    { 600, "Meerut", 27 },
                    { 601, "Mirzapur", 27 },
                    { 602, "Moradabad", 27 },
                    { 603, "Muzaffarnagar", 27 },
                    { 604, "Pilibhit", 27 },
                    { 605, "Pratapgarh(UP)", 27 },
                    { 606, "Rae_Bareli", 27 },
                    { 607, "Rampur", 27 },
                    { 608, "Saharanpur", 27 },
                    { 609, "Sambhal", 27 },
                    { 610, "Sant_Kabir_Nagar", 27 },
                    { 611, "Sant_Ravidas_Nagar", 27 },
                    { 612, "Shahjahanpur", 27 },
                    { 614, "Shrawasti", 27 },
                    { 635, "Bankura", 29 },
                    { 636, "Barddhaman", 29 },
                    { 637, "Birbhum", 29 },
                    { 660, "Shahdara", 30 },
                    { 661, "South East Delhi", 30 },
                    { 662, "South_Delhi", 30 },
                    { 663, "South_West_Delhi", 30 },
                    { 664, "West_Delhi", 30 },
                    { 665, "Chandigarh", 31 },
                    { 666, "Nicobar", 32 },
                    { 667, "North& Middle Andaman", 32 },
                    { 668, "South Andamans", 32 },
                    { 669, "Karaikal", 33 },
                    { 670, "Mahe", 33 },
                    { 671, "Yanam", 33 },
                    { 672, "Lakshadweep", 34 },
                    { 673, "Dadra_and_Nagar_Haveli", 35 },
                    { 674, "Daman", 36 },
                    { 675, "Diu", 36 },
                    { 676, "Puducherry", 37 },
                    { 659, "North_West_Delhi", 30 },
                    { 658, "North_East_Delhi", 30 },
                    { 657, "North_Delhi", 30 },
                    { 656, "New_Delhi", 30 },
                    { 638, "Cooch_Behar", 29 },
                    { 639, "Dakshin_Dinajpur", 29 },
                    { 640, "Darjeeling", 29 },
                    { 641, "Hooghly", 29 },
                    { 642, "Howrah", 29 },
                    { 643, "Jalpaiguri", 29 },
                    { 644, "Kolkata", 29 },
                    { 645, "Malda", 29 },
                    { 595, "Maharajganj", 27 },
                    { 646, "Murshidabad", 29 },
                    { 648, "North_24_Parganas", 29 },
                    { 649, "Paschim_Medinipur", 29 },
                    { 650, "Purba_Medinipur", 29 },
                    { 651, "Puruliya", 29 },
                    { 652, "South_24_Parganas", 29 },
                    { 653, "Uttar_Dinajpur", 29 },
                    { 654, "Central_Delhi", 30 },
                    { 655, "East_Delhi", 30 },
                    { 647, "Nadia", 29 },
                    { 340, "Chandrapur", 15 },
                    { 594, "Lucknow", 27 },
                    { 592, "Lakhimpur Kheri", 27 },
                    { 532, "Nalgonda", 25 },
                    { 533, "Nizamabad", 25 },
                    { 534, "Adilabad", 25 },
                    { 535, "Hyderabad", 25 },
                    { 536, "K.v._Rangareddy", 25 },
                    { 537, "Warangal", 25 },
                    { 538, "Dhalai", 26 },
                    { 539, "Gomati", 26 },
                    { 540, "Khowai", 26 },
                    { 541, "North_Tripura", 26 },
                    { 542, "Sepahijala", 26 },
                    { 543, "South_Tripura", 26 },
                    { 544, "Unakoti", 26 },
                    { 545, "West_Tripura", 26 },
                    { 546, "Agra", 27 },
                    { 547, "Aligarh", 27 },
                    { 548, "Allahabad", 27 },
                    { 531, "Medak", 25 },
                    { 549, "Ambedkar_Nagar", 27 },
                    { 530, "Mahbubnagar", 25 },
                    { 528, "Karimnagar", 25 },
                    { 511, "Perambalur", 24 },
                    { 512, "Pudukkottai", 24 },
                    { 513, "Ramanathapuram", 24 },
                    { 514, "Salem", 24 },
                    { 515, "Sivaganga", 24 },
                    { 516, "Thanjavur", 24 },
                    { 517, "Theni", 24 },
                    { 518, "Thiruvarur", 24 },
                    { 519, "Thoothukkudi", 24 },
                    { 520, "Tiruchirappalli", 24 },
                    { 521, "Tirunelveli", 24 },
                    { 522, "Tirupur", 24 },
                    { 523, "Tiruvallur", 24 },
                    { 524, "Tiruvannamalai", 24 },
                    { 525, "Vellore", 24 },
                    { 526, "Villupuram", 24 },
                    { 527, "Virudhunagar", 24 },
                    { 529, "Khammam", 25 },
                    { 550, "Amethi", 27 },
                    { 551, "Amroha", 27 },
                    { 552, "Auraiya", 27 },
                    { 575, "Ghaziabad", 27 },
                    { 576, "Ghazipur", 27 },
                    { 577, "Gonda", 27 },
                    { 578, "Gorakhpur", 27 },
                    { 579, "Hamirpur(UP)", 27 },
                    { 580, "Hapur", 27 },
                    { 581, "Hardoi", 27 },
                    { 582, "Hathras", 27 },
                    { 583, "Jalaun", 27 },
                    { 584, "Jaunpur", 27 },
                    { 585, "Jhansi", 27 },
                    { 586, "Kannauj", 27 },
                    { 587, "Kanpur_Dehat", 27 },
                    { 588, "Kanpur_Nagar", 27 },
                    { 589, "Kashiram Nagar", 27 },
                    { 590, "Kaushambi", 27 },
                    { 591, "Kushinagar", 27 },
                    { 574, "Gautam_Buddha_Nagar", 27 },
                    { 573, "Firozabad", 27 },
                    { 572, "Fatehpur", 27 },
                    { 571, "Farrukhabad", 27 },
                    { 553, "Azamgarh", 27 },
                    { 554, "Baghpat", 27 },
                    { 555, "Bahraich", 27 },
                    { 556, "Ballia", 27 },
                    { 557, "Balrampur(UP)", 27 },
                    { 558, "Banda", 27 },
                    { 559, "Bara_Banki", 27 },
                    { 560, "Bareilly", 27 },
                    { 593, "Lalitpur", 27 },
                    { 561, "Basti", 27 },
                    { 563, "Budaun", 27 },
                    { 564, "Bulandshahr", 27 },
                    { 565, "Chandauli", 27 },
                    { 566, "Chitrakoot", 27 },
                    { 567, "Deoria", 27 },
                    { 568, "Etah", 27 },
                    { 569, "Etawah", 27 },
                    { 570, "Faizabad", 27 },
                    { 562, "Bijnor", 27 },
                    { 339, "Buldhana", 15 },
                    { 356, "Palghar", 15 },
                    { 337, "Beed", 15 },
                    { 107, "Janjgir-champa", 5 },
                    { 108, "Jashpur", 5 },
                    { 109, "Kabirdham", 5 },
                    { 110, "Kanker", 5 },
                    { 111, "Kondagaon", 5 },
                    { 112, "Korba", 5 },
                    { 113, "Koriya", 5 },
                    { 114, "Mahasamund", 5 },
                    { 115, "Mungeli", 5 },
                    { 116, "Narayanpur", 5 },
                    { 117, "Raigarh", 5 },
                    { 118, "Raipur", 5 },
                    { 119, "Rajnandgaon", 5 },
                    { 120, "Sukma", 5 },
                    { 121, "Surajpur", 5 },
                    { 122, "Surguja", 5 },
                    { 123, "North_Goa", 6 },
                    { 106, "Gariyaband", 5 },
                    { 124, "South_Goa", 6 },
                    { 105, "Durg", 5 },
                    { 103, "Dantewada", 5 },
                    { 86, "Saharsa", 4 },
                    { 87, "Samastipur", 4 },
                    { 88, "Saran", 4 },
                    { 89, "Sheikhpura", 4 },
                    { 90, "Sheohar", 4 },
                    { 91, "Sitamarhi", 4 },
                    { 92, "Siwan", 4 },
                    { 93, "Supaul", 4 },
                    { 94, "Vaishali", 4 },
                    { 95, "West_Champaran", 4 },
                    { 96, "Balod", 5 },
                    { 97, "Baloda_Bazar", 5 },
                    { 98, "Balrampur", 5 },
                    { 99, "Bastar", 5 },
                    { 100, "Bemetara", 5 },
                    { 101, "Bijapur", 5 },
                    { 102, "Bilaspur", 5 },
                    { 104, "Dhamtari", 5 },
                    { 125, "Ahmedabad", 7 },
                    { 126, "Amreli", 7 },
                    { 127, "Anand", 7 },
                    { 150, "Rajkot", 7 },
                    { 338, "Bhandara", 15 },
                    { 152, "Surat", 7 },
                    { 153, "Surendra_Nagar", 7 },
                    { 154, "Tapi", 7 },
                    { 155, "The_Dangs", 7 },
                    { 156, "Vadodara", 7 },
                    { 157, "Valsad", 7 },
                    { 158, "Ambala", 8 },
                    { 159, "Bhiwani", 8 },
                    { 160, "Faridabad", 8 },
                    { 161, "Fatehabad", 8 },
                    { 162, "Gurgaon", 8 },
                    { 163, "Hisar", 8 },
                    { 164, "Jhajjar", 8 },
                    { 165, "Jind", 8 },
                    { 166, "Kaithal", 8 },
                    { 149, "Porbandar", 7 },
                    { 148, "Patan", 7 },
                    { 147, "Panchmahals", 7 },
                    { 146, "Navsari", 7 },
                    { 128, "Aravalli", 7 },
                    { 129, "Banaskantha", 7 },
                    { 130, "Bharuch", 7 },
                    { 131, "Bhavnagar", 7 },
                    { 132, "Botad", 7 },
                    { 133, "Chhotaudepur", 7 },
                    { 134, "Dahod", 7 },
                    { 135, "Devbhumi Dwarka", 7 },
                    { 85, "Rohtas", 4 },
                    { 136, "Gandhinagar", 7 },
                    { 138, "Jamnagar", 7 },
                    { 139, "Junagadh", 7 },
                    { 140, "Kachchh", 7 },
                    { 141, "Kheda", 7 },
                    { 142, "Mahesana", 7 },
                    { 143, "Mahisagar", 7 },
                    { 144, "Morbi", 7 },
                    { 145, "Narmada", 7 },
                    { 137, "Gir Somnath", 7 },
                    { 167, "Karnal", 8 },
                    { 84, "Purnia", 4 },
                    { 82, "Nawada", 4 },
                    { 22, "Lower_Dibang_Valley", 2 },
                    { 23, "Lower_Subansiri", 2 },
                    { 24, "Papum_Pare", 2 },
                    { 25, "Tawang", 2 },
                    { 26, "Tirap", 2 },
                    { 27, "Upper_Siang", 2 },
                    { 28, "Upper_Subansiri", 2 },
                    { 29, "West_Kameng", 2 },
                    { 30, "West_Siang", 2 },
                    { 31, "Baksa", 3 },
                    { 32, "Barpeta", 3 },
                    { 33, "Bongaigaon", 3 },
                    { 34, "Cachar", 3 },
                    { 35, "Chirang", 3 },
                    { 36, "Darrang", 3 },
                    { 37, "Dhemaji", 3 },
                    { 38, "Dhubri", 3 },
                    { 21, "Longding", 2 },
                    { 39, "Dibrugarh", 3 },
                    { 20, "Lohit", 2 },
                    { 18, "East_Siang", 2 },
                    { 1, "Ananthapur", 1 },
                    { 2, "Chittoor", 1 },
                    { 3, "Cuddapah", 1 },
                    { 4, "East_Godavari", 1 },
                    { 5, "Guntur", 1 },
                    { 6, "Krishna", 1 },
                    { 7, "Prakasam", 1 },
                    { 8, "Srikakulam", 1 },
                    { 9, "Kurnool", 1 },
                    { 10, "Nellore", 1 },
                    { 11, "Visakhapatnam", 1 },
                    { 12, "Vizianagaram", 1 },
                    { 13, "West_Godavari", 1 },
                    { 14, "Anjaw", 2 },
                    { 15, "Changlang", 2 },
                    { 16, "Dibang_Valley", 2 },
                    { 17, "East_Kameng", 2 },
                    { 19, "Kurung_Kumey", 2 },
                    { 40, "Goalpara", 3 },
                    { 41, "Golaghat", 3 },
                    { 42, "Hailakandi", 3 },
                    { 65, "Bhojpur", 4 },
                    { 66, "Buxar", 4 },
                    { 67, "Darbhanga", 4 },
                    { 68, "East_Champaran", 4 },
                    { 69, "Gaya", 4 },
                    { 70, "Gopalganj", 4 },
                    { 71, "Jamui", 4 },
                    { 72, "Jehanabad", 4 },
                    { 73, "Katihar", 4 },
                    { 74, "Khagaria", 4 },
                    { 75, "Kishanganj", 4 },
                    { 76, "Lakhisarai", 4 },
                    { 77, "Madhepura", 4 },
                    { 78, "Madhubani", 4 },
                    { 79, "Munger", 4 },
                    { 80, "Muzaffarpur", 4 },
                    { 81, "Nalanda", 4 },
                    { 64, "Bhagalpur", 4 },
                    { 63, "Bhabua", 4 },
                    { 62, "Begusarai", 4 },
                    { 61, "Banka", 4 },
                    { 43, "Jorhat", 3 },
                    { 44, "Kamrup", 3 },
                    { 45, "Kamrup_Metro", 3 },
                    { 46, "Karbi_Anglong", 3 },
                    { 47, "Karimganj", 3 },
                    { 48, "Kokrajhar", 3 },
                    { 49, "Lakhimpur", 3 },
                    { 50, "Marigaon", 3 },
                    { 83, "Patna", 4 },
                    { 51, "Nagaon", 3 },
                    { 53, "North_Cachar_Hills", 3 },
                    { 54, "Sibsagar", 3 },
                    { 55, "Sonitpur", 3 },
                    { 56, "Tinsukia", 3 },
                    { 57, "Udalguri", 3 },
                    { 58, "Araria", 4 },
                    { 59, "Arwal", 4 },
                    { 60, "Aurangabad", 4 },
                    { 52, "Nalbari", 3 },
                    { 168, "Kurukshetra", 8 },
                    { 151, "Sabarkantha", 7 },
                    { 170, "Mewat", 8 },
                    { 277, "Pathanamthitta", 13 },
                    { 278, "Thiruvananthapuram", 13 },
                    { 279, "Thrissur", 13 },
                    { 280, "Wayanad", 13 },
                    { 281, "Burhanpur", 14 },
                    { 282, "Harda", 14 },
                    { 283, "Hoshangabad", 14 },
                    { 284, "Agar", 14 },
                    { 285, "Alirajpur", 14 },
                    { 286, "Anuppur", 14 },
                    { 287, "Ashok_Nagar", 14 },
                    { 288, "Balaghat", 14 },
                    { 289, "Barwani", 14 },
                    { 290, "Betul", 14 },
                    { 291, "Bhind", 14 },
                    { 292, "Bhopal", 14 },
                    { 293, "Chhatarpur", 14 },
                    { 276, "Palakkad", 13 },
                    { 294, "Chhindwara", 14 },
                    { 275, "Malappuram", 13 },
                    { 273, "Kottayam", 13 },
                    { 256, "Kolar", 12 },
                    { 257, "Koppal", 12 },
                    { 258, "Mandya", 12 },
                    { 259, "Raichur", 12 },
                    { 260, "Ramanagar", 12 },
                    { 261, "Shimoga", 12 },
                    { 262, "Udupi", 12 },
                    { 263, "Uttara_Kannada", 12 },
                    { 264, "Yadgir", 12 },
                    { 265, "Mysore", 12 },
                    { 266, "Tumkur", 12 },
                    { 267, "Alappuzha", 13 },
                    { 268, "Ernakulam", 13 },
                    { 269, "Idukki", 13 },
                    { 270, "Kannur", 13 },
                    { 271, "Kasaragod", 13 },
                    { 169, "Mahendragarh", 8 },
                    { 274, "Kozhikode", 13 },
                    { 295, "Damoh", 14 },
                    { 296, "Datia", 14 },
                    { 297, "Dewas", 14 },
                    { 320, "Seoni", 14 },
                    { 321, "Shahdol", 14 },
                    { 322, "Shajapur", 14 },
                    { 323, "Sheopur", 14 },
                    { 324, "Shivpuri", 14 },
                    { 325, "Sidhi", 14 },
                    { 326, "Singrauli", 14 },
                    { 327, "Tikamgarh", 14 },
                    { 328, "Ujjain", 14 },
                    { 329, "Umaria", 14 },
                    { 330, "Vidisha", 14 },
                    { 331, "Khandwa", 14 },
                    { 332, "Amravati", 15 },
                    { 333, "Wardha", 15 },
                    { 334, "Ahmadnagar", 15 },
                    { 335, "Akola", 15 },
                    { 336, "Aurangabad(MH)", 15 },
                    { 319, "Sehore", 14 },
                    { 318, "Satna", 14 },
                    { 317, "Sagar", 14 },
                    { 316, "Rewa", 14 },
                    { 298, "Dhar", 14 },
                    { 299, "Dindori", 14 },
                    { 300, "Guna", 14 },
                    { 301, "Gwalior", 14 },
                    { 302, "Indore", 14 },
                    { 303, "Jabalpur", 14 },
                    { 304, "Jhabua", 14 },
                    { 305, "Katni", 14 },
                    { 255, "Kodagu", 12 },
                    { 306, "Khargone", 14 },
                    { 308, "Mandsaur", 14 },
                    { 309, "Morena", 14 },
                    { 310, "Narsinghpur", 14 },
                    { 311, "Neemuch", 14 },
                    { 312, "Panna", 14 },
                    { 313, "Raisen", 14 },
                    { 314, "Rajgarh", 14 },
                    { 315, "Ratlam", 14 },
                    { 307, "Mandla", 14 },
                    { 254, "Haveri", 12 },
                    { 272, "Kollam", 13 },
                    { 252, "Gulbarga", 12 },
                    { 192, "Badgam", 10 },
                    { 253, "Hassan", 12 },
                    { 194, "Baramula", 10 },
                    { 195, "Doda", 10 },
                    { 196, "Ganderbal", 10 },
                    { 197, "Jammu", 10 },
                    { 198, "Kargil", 10 },
                    { 199, "Kathua", 10 },
                    { 200, "Kishtwar", 10 },
                    { 201, "Kulgam", 10 },
                    { 202, "Kupwara", 10 },
                    { 203, "Leh", 10 },
                    { 204, "Pulwama", 10 },
                    { 205, "Punch", 10 },
                    { 206, "Rajouri", 10 },
                    { 207, "Ramban", 10 },
                    { 208, "Reasi", 10 },
                    { 191, "Anantnag", 10 },
                    { 209, "Samba", 10 },
                    { 190, "Lahul_and_Spiti", 9 },
                    { 188, "Solan", 9 },
                    { 171, "Palwal", 8 },
                    { 172, "Panchkula", 8 },
                    { 173, "Panipat", 8 },
                    { 174, "Rewari", 8 },
                    { 175, "Rohtak", 8 },
                    { 176, "Sirsa", 8 },
                    { 177, "Sonipat", 8 },
                    { 178, "Yamuna_Nagar", 8 },
                    { 179, "Kinnaur", 9 },
                    { 180, "Bilaspur(HP)", 9 },
                    { 181, "Chamba", 9 },
                    { 182, "Hamirpur", 9 },
                    { 183, "Kangra", 9 },
                    { 184, "Kullu", 9 },
                    { 185, "Mandi", 9 },
                    { 186, "Shimla", 9 },
                    { 187, "Sirmaur", 9 },
                    { 189, "Una", 9 },
                    { 210, "Shupiyan", 10 },
                    { 193, "Bandipore", 10 },
                    { 212, "Udhampur", 10 },
                    { 235, "Simdega", 11 },
                    { 236, "West_Singhbhum", 11 },
                    { 237, "Bagalkot", 12 },
                    { 238, "Bangalore", 12 },
                    { 239, "Bangalore_Rural", 12 },
                    { 240, "Belgaum", 12 },
                    { 241, "Bellary", 12 },
                    { 242, "Bidar", 12 },
                    { 243, "Bijapur(KAT)", 12 },
                    { 244, "Chamrajanagar", 12 },
                    { 245, "Chickmagalur", 12 },
                    { 246, "Chikkaballapur", 12 },
                    { 247, "Chitradurga", 12 },
                    { 248, "Dakshina_Kannada", 12 },
                    { 211, "Srinagar", 10 },
                    { 250, "Dharwad", 12 },
                    { 251, "Gadag", 12 },
                    { 234, "Seraikela-Kharsawan", 11 },
                    { 233, "Sahebganj", 11 },
                    { 249, "Davangere", 12 },
                    { 231, "Ramgarh", 11 },
                    { 232, "Ranchi", 11 },
                    { 213, "Bokaro", 11 },
                    { 215, "Deoghar", 11 },
                    { 216, "Dhanbad", 11 },
                    { 217, "Dumka", 11 },
                    { 218, "East_Singhbhum", 11 },
                    { 219, "Garhwa", 11 },
                    { 220, "Giridih", 11 },
                    { 221, "Godda", 11 },
                    { 214, "Chatra", 11 },
                    { 223, "Hazaribagh", 11 },
                    { 224, "Jamtara", 11 },
                    { 225, "Khunti", 11 },
                    { 226, "Koderma", 11 },
                    { 227, "Latehar", 11 },
                    { 228, "Lohardaga", 11 },
                    { 229, "Pakur", 11 },
                    { 222, "Gumla", 11 },
                    { 230, "Palamu", 11 }
                });

            migrationBuilder.InsertData(
                table: "State_Details",
                columns: new[] { "StateID", "CountryID", "StateName" },
                values: new object[,]
                {
                    { 21, 1, "Punjab" },
                    { 22, 1, "Rajasthan" },
                    { 23, 1, "Sikkim" },
                    { 24, 1, "Tamil Nadu" },
                    { 25, 1, "Telangana" },
                    { 26, 1, "Tripura" },
                    { 27, 1, "Uttar Pradesh" },
                    { 31, 1, "Chandigarh" },
                    { 29, 1, "West Bengal" },
                    { 30, 1, "Delhi" },
                    { 32, 1, "Andaman and Nicobar" },
                    { 33, 1, "Puducherry" },
                    { 34, 1, "Lakshadweep" },
                    { 20, 1, "Orissa" },
                    { 35, 1, "Dadra and Nagar Haveli" },
                    { 28, 1, "Uttarakhand" },
                    { 19, 1, "Nagaland" },
                    { 9, 1, "Himachal Pradesh" },
                    { 17, 1, "Meghalaya" },
                    { 36, 1, "Daman and Diu" },
                    { 1, 1, "Andhra Pradesh" },
                    { 2, 1, "Arunachal Pradesh" }
                });

            migrationBuilder.InsertData(
                table: "State_Details",
                columns: new[] { "StateID", "CountryID", "StateName" },
                values: new object[,]
                {
                    { 3, 1, "Assam" },
                    { 4, 1, "Bihar" },
                    { 5, 1, "Chhattisgarh" },
                    { 6, 1, "Goa" },
                    { 18, 1, "Mizoram" },
                    { 7, 1, "Gujarat" },
                    { 10, 1, "Jammu & Kashmir" },
                    { 11, 1, "Jharkhand" },
                    { 12, 1, "Karnataka" },
                    { 13, 1, "Kerala" },
                    { 14, 1, "Madhya Pradesh" },
                    { 15, 1, "Maharashtra" },
                    { 16, 1, "Manipur" },
                    { 8, 1, "Haryana" },
                    { 37, 1, "Puducherry" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Country_Details",
                keyColumn: "CountryID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "District_Details",
                keyColumn: "DistrictID",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "State_Details",
                keyColumn: "StateID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "State_Details",
                keyColumn: "StateID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "State_Details",
                keyColumn: "StateID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "State_Details",
                keyColumn: "StateID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "State_Details",
                keyColumn: "StateID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "State_Details",
                keyColumn: "StateID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "State_Details",
                keyColumn: "StateID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "State_Details",
                keyColumn: "StateID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "State_Details",
                keyColumn: "StateID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "State_Details",
                keyColumn: "StateID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "State_Details",
                keyColumn: "StateID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "State_Details",
                keyColumn: "StateID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "State_Details",
                keyColumn: "StateID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "State_Details",
                keyColumn: "StateID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "State_Details",
                keyColumn: "StateID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "State_Details",
                keyColumn: "StateID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "State_Details",
                keyColumn: "StateID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "State_Details",
                keyColumn: "StateID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "State_Details",
                keyColumn: "StateID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "State_Details",
                keyColumn: "StateID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "State_Details",
                keyColumn: "StateID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "State_Details",
                keyColumn: "StateID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "State_Details",
                keyColumn: "StateID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "State_Details",
                keyColumn: "StateID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "State_Details",
                keyColumn: "StateID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "State_Details",
                keyColumn: "StateID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "State_Details",
                keyColumn: "StateID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "State_Details",
                keyColumn: "StateID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "State_Details",
                keyColumn: "StateID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "State_Details",
                keyColumn: "StateID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "State_Details",
                keyColumn: "StateID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "State_Details",
                keyColumn: "StateID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "State_Details",
                keyColumn: "StateID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "State_Details",
                keyColumn: "StateID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "State_Details",
                keyColumn: "StateID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "State_Details",
                keyColumn: "StateID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "State_Details",
                keyColumn: "StateID",
                keyValue: 37);
        }
    }
}
