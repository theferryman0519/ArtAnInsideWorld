using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using System.Data;
using System.IO;

public class MainGalleryDatabase : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	// Main Gallery Information - TEMPLATE
	public static string AppGalleryName0;
	public static string AppGalleryDescription0;

	// Individual Painting Information - TEMPLATE
	public static string Cat0AppPainting00Name;
	public static string Cat0AppPainting00Artist;
	public static string Cat0AppPainting00GalleryName;
	public static int Cat0AppPainting00GalleryNumber;
	public static string Cat0AppPainting00Movement;
	public static string Cat0AppPainting00Origintation;
	public static string Cat0AppPainting00Nationality;
	public static string Cat0AppPainting00Date;
	public static string Cat0AppPainting00MainDescription;
	public static string Cat0AppPainting00MuseumName;
	public static string Cat0AppPainting00MuseumLocation;
	public static string Cat0AppPainting00ARPieceName1;
	public static string Cat0AppPainting00ARPieceDescription1;
	public static string Cat0AppPainting00ARPieceName2;
	public static string Cat0AppPainting00ARPieceDescription2;
	public static string Cat0AppPainting00ARPieceName3;
	public static string Cat0AppPainting00ARPieceDescription3;
	public static string Cat0AppPainting00ARPieceName4;
	public static string Cat0AppPainting00ARPieceDescription4;
	public static string Cat0AppPainting00ARPieceName5;
	public static string Cat0AppPainting00ARPieceDescription5;


// ********************************************* GALLERY CAT 1 *********************************************
	// Main Gallery Information
	public static string AppGalleryName1 = "Art of Britain & America";
	public static string AppGalleryDescription1 = "Great Britain and the United States have given the art world talented artists who have either studied or been influenced by European and Eastern masters. Art movements of the 19th and 20th Centuries conquered these regions, specifically movements such as Romanticism, Realism, and Modernism." + "\n" + "\n" + "Originating in in Europe during the end of the 18th Century, Romantic art emphasized emotion and feeling of individuals as well as almost glorifying nature and history. Unlike the Baroque and Renaissance Ages where the focus was more Classical in nature, Romantic works of art focused more on the Medieval, adding a sense of heroism to paintings and sculptures." + "\n" + "\n" + "Modernism was a philosophical movement that influenced art during the late stages of the 19th Century and into the 20th. Artists during this time rejected the religious and spiritual themes of the Enlightenment, and Modernists showcased rhetoric of modern society and industrialism." + "\n" + "\n" + "The Age of Realism began in France during the middle of the 19th Century and made its way across the world. Realism sought to depict scenes of everyday life, whether that would be people, nature, or cityscapes. Photorealism was an offshoot of the Age of Realism, as artists created paintings that had photographic qualities. The goal of Realism was to draw viewers into their art, giving the extreme believability that the viewer was placed within the artwork as it came to life." + "\n" + "\n" + "The artists featured in the Art of Britain & America Gallery include John Constable, Edward Hopper, John Everett Millais, JMW Turner, and Grant Wood.";

	// Individual Painting Information - Cat1AppPainting01
	public static string Cat1AppPainting01Name = "American Gothic";
	public static string Cat1AppPainting01Artist = "Grant Wood";
	public static string Cat1AppPainting01GalleryName = "Art of Britain & America";
	public static int Cat1AppPainting01GalleryNumber = 1;
	public static string Cat1AppPainting01Movement = "Realism";
	public static string Cat1AppPainting01Origintation = "Eldon, Iowa";
	public static string Cat1AppPainting01Nationality = "American";
	public static string Cat1AppPainting01Date = "1930";
	public static string Cat1AppPainting01MainDescription = "Born and lived in Iowa during the early 20th Century, Grant Wood was an American painter who is known for his masterpiece American Gothic. Wood's realism extended into the American Midwest, sparking a branch of the Age of Realism known as Regionalism, depicting the colonial-style, everyday life of families during the time of Westward Expansion, the Great Depression, and Manifest Destiny. Comparable to Leonardo da Vinci's Mona Lisa, Grant Wood's American Gothic is iconic, timeless, and visibly known around the world. Wood depicts the quintessential couple of the American Midwest during the time of the Great Depression and the Dust Bowl. Very often mistaken to be his wife, Wood shows a farmer standing next to his daughter. The painting is one that is constantly parodied by other artists, filmmakers, or internet-goers due to its iconic nature.";
	public static string Cat1AppPainting01MuseumName = "Art Institute of Chicago";
	public static string Cat1AppPainting01MuseumLocation = "Chicago, Illinois, United States of America";
	public static string Cat1AppPainting01ARPieceName1 = "Pitchfork";
	public static string Cat1AppPainting01ARPieceDescription1 = "xxxxxxxx";
	public static string Cat1AppPainting01ARPieceName2 = "Dibble House";
	public static string Cat1AppPainting01ARPieceDescription2 = "xxxxxxxx";
	public static string Cat1AppPainting01ARPieceName3 = "Iowan Land";
	public static string Cat1AppPainting01ARPieceDescription3 = "xxxxxxxx";

	// Individual Painting Information - Cat1AppPainting02
	public static string Cat1AppPainting02Name = "Battle of Trafalgar, The";
	public static string Cat1AppPainting02Artist = "J.M.W. Turner";
	public static string Cat1AppPainting02GalleryName = "Art of Britain & America";
	public static int Cat1AppPainting02GalleryNumber = 1;
	public static string Cat1AppPainting02Movement = "Romanticism";
	public static string Cat1AppPainting02Origintation = "Yorkshire, United Kingdom";
	public static string Cat1AppPainting02Nationality = "English";
	public static string Cat1AppPainting02Date = "1823";
	public static string Cat1AppPainting02MainDescription = "Joseph Mallord William Turner, better known as J.M.W. Turner, was born in London and became one of the leading British Romantic painters of the 19th Century. He was known for his turbulent, fluid, rambunctious landscape and maritime scenes, as seen within his paintings such as his Fishermen at Sea, Calais Pier, and his Raby Castle. The technical ability of Turner is shown within the precise depictions of objects and figures within his paintings, yet the Romantic appeal carries through each work as the rendered atmosphere, fluid brushstrokes, and captivating lighting enhance the emotion and drama of each scene. Completed in 1823 by Joseph Mallord William Turner, The Battle of Trafalgar commemorates a maritime victory by the Hanover Dynasty, commissioned by King George IV of the United Kingdom. During this battle,which occurred on October 21, 1805, the British fleet under the command of Admiral Horatio Nelson led a change against the Franco-Spanish Navy. Nelson and the British fleet split in two to catch the opposition off guard, which worked in the end. Unfortunately, Nelson was shot and would later die. The painting by Turner showcases the realistic elements of the battle, down to the cannon holes and number of sails on Nelson's flagship, the Victory. However, the Romantic aesthetics appear as Turner creates a sense of memoriam to honor those who lost their lives for this war-altering battle, including Admiral Nelson.";
	public static string Cat1AppPainting02MuseumName = "National Maritime Museum";
	public static string Cat1AppPainting02MuseumLocation = "London, United Kingdom";
	public static string Cat1AppPainting02ARPieceName1 = "Ship Flags";
	public static string Cat1AppPainting02ARPieceDescription1 = "xxxxxxxx";
	public static string Cat1AppPainting02ARPieceName2 = "Ship Hull";
	public static string Cat1AppPainting02ARPieceDescription2 = "xxxxxxxx";
	public static string Cat1AppPainting02ARPieceName3 = "Clouds";
	public static string Cat1AppPainting02ARPieceDescription3 = "xxxxxxxx";
	public static string Cat1AppPainting02ARPieceName4 = "Union Jack Flag";
	public static string Cat1AppPainting02ARPieceDescription4 = "xxxxxxxx";

	// Individual Painting Information - Cat1AppPainting03
	public static string Cat1AppPainting03Name = "Fighting Temeraire, The";
	public static string Cat1AppPainting03Artist = "J.M.W. Turner";
	public static string Cat1AppPainting03GalleryName = "Art of Britain & America";
	public static int Cat1AppPainting03GalleryNumber = 1;
	public static string Cat1AppPainting03Movement = "Romanticism";
	public static string Cat1AppPainting03Origintation = "Yorkshire, United Kingdom";
	public static string Cat1AppPainting03Nationality = "English";
	public static string Cat1AppPainting03Date = "1838";
	public static string Cat1AppPainting03MainDescription = "Joseph Mallord William Turner, better known as J.M.W. Turner, was born in London and became one of the leading British Romantic painters of the 19th Century. He was known for his turbulent, fluid, rambunctious landscape and maritime scenes, as seen within his paintings such as his Fishermen at Sea, Calais Pier, and his Raby Castle. The technical ability of Turner is shown within the precise depictions of objects and figures within his paintings, yet the Romantic appeal carries through each work as the rendered atmosphere, fluid brushstrokes, and captivating lighting enhance the emotion and drama of each scene. Shortened from its full title of The Fighting Temeraire, Tugged to Her Last Berth to be Broken Up, 1838 to just The Fighting Temeraire, Joseph Mallord William Turner depicts the HMS Temeraire as one of the last of its types of ships which participated in the Battle of Trafalgar. Turner shows the sunset on the ocean as a tugboat is pulling the large vessel to where it will last make port before being broken up for scrap and recycled material. The sunset and clouds in the atmosphere behind the two ships is symbolic of the 'sunset' of the HMS Temeraire as her last couple of hours as an entire ship. In 2005, Turner's painting was voted as the nation's favorite work of painting within the United Kingdom.";
	public static string Cat1AppPainting03MuseumName = "National Gallery";
	public static string Cat1AppPainting03MuseumLocation = "London, United Kingdom";
	public static string Cat1AppPainting03ARPieceName1 = "Tugboat";
	public static string Cat1AppPainting03ARPieceDescription1 = "xxxxxxxx";
	public static string Cat1AppPainting03ARPieceName2 = "Sunset";
	public static string Cat1AppPainting03ARPieceDescription2 = "xxxxxxxx";
	public static string Cat1AppPainting03ARPieceName3 = "Moonlight";
	public static string Cat1AppPainting03ARPieceDescription3 = "xxxxxxxx";
	public static string Cat1AppPainting03ARPieceName4 = "Ship";
	public static string Cat1AppPainting03ARPieceDescription4 = "xxxxxxxx";
	public static string Cat1AppPainting03ARPieceName5 = "Coastal City";
	public static string Cat1AppPainting03ARPieceDescription5 = "xxxxxxxx";

	// Individual Painting Information - Cat1AppPainting04
	public static string Cat1AppPainting04Name = "Hay Wain, The";
	public static string Cat1AppPainting04Artist = "John Constable";
	public static string Cat1AppPainting04GalleryName = "Art of Britain & America";
	public static int Cat1AppPainting04GalleryNumber = 1;
	public static string Cat1AppPainting04Movement = "Romanticism";
	public static string Cat1AppPainting04Origintation = "Sudbury, United Kingdom";
	public static string Cat1AppPainting04Nationality = "English";
	public static string Cat1AppPainting04Date = "1821";
	public static string Cat1AppPainting04MainDescription = "Suffolk-born painter John Constable was best known for his British landscape paintings. Comparable to the eccentric and active atmospheres of Dutch master Jacob van Ruisdael, Constable's paintings show emotional and active skies that add to the drama of the landscape scenes. This can be seen within his Dedham Vale, The Hay Wain, and his Wivenhoe Park. Also relatable to that of van Ruisdael, the atmospheric depictions by Constable helped lead to create a visual reference for some of the first meteorological guides in identifying clouds. Currently residing in the National Gallery in London, The Hay Wain is considered to be John Constable's most famous work of art. Composed in 1821, the painting is comparable to the Golden Age paintings of Dutch artist Jacob van Ruisdael. Constable integrates feeling, tone, and emotion within his atmosphere to captivate viewers as they view the scene of the Suffolk landscape. The wain, which is a large wagon used on farms to haul goods, can be seen carrying hay and wood by horse across the shallow body of water. Constable focuses on the daily life of British laborers and families during the early 19th Century.";
	public static string Cat1AppPainting04MuseumName = "National Gallery";
	public static string Cat1AppPainting04MuseumLocation = "London, United Kingdom";
	public static string Cat1AppPainting04ARPieceName1 = "Lott Cottage";
	public static string Cat1AppPainting04ARPieceDescription1 = "xxxxxxxx";
	public static string Cat1AppPainting04ARPieceName2 = "Wagon";
	public static string Cat1AppPainting04ARPieceDescription2 = "xxxxxxxx";
	public static string Cat1AppPainting04ARPieceName3 = "River";
	public static string Cat1AppPainting04ARPieceDescription3 = "xxxxxxxx";
	public static string Cat1AppPainting04ARPieceName4 = "Clouds";
	public static string Cat1AppPainting04ARPieceDescription4 = "xxxxxxxx";

	// Individual Painting Information - Cat1AppPainting05
	public static string Cat1AppPainting05Name = "Nighthawks";
	public static string Cat1AppPainting05Artist = "Edward Hopper";
	public static string Cat1AppPainting05GalleryName = "Art of Britain & America";
	public static int Cat1AppPainting05GalleryNumber = 1;
	public static string Cat1AppPainting05Movement = "Modernism";
	public static string Cat1AppPainting05Origintation = "New York City, New York, United States of America";
	public static string Cat1AppPainting05Nationality = "American";
	public static string Cat1AppPainting05Date = "1942";
	public static string Cat1AppPainting05MainDescription = "New York painter Edward Hopper was known for his oil and watercolor paintings that depicted Modern scenes of both urban and rural life in America, or at least what was Modern to Hopper. Within the realm of Realism, Hopper's style of Modern art included diluted hues and muted lighting, adding a sense of emotion of mood to the otherwise industrial or agricultural scenes. These scenes were idealized in the sense that they represent America as a whole during the 20th Century as opposed to specific locations around the United States. These idealizations were found within his paintings that included his Chop Suey, Hotel Lobby, and his most iconic Nighthawks. Edward Hopper's Nighthawks is one of the most recognizable paintings in American art history. Sold for a mere $3,000 just months after its completion in 1942, Hopper's painting portrays a small diner on a street corner, being visited by three figures during the night. The rest of the rustling and bustling of the daily urban life is nonexistent within the background of the scene, as the main light source to illuminate the diner comes from its ceiling lights. The overall mood of the piece is calmness and serenity, which is quite the opposite of what would appear on this corner during the day of industrial, urban life.";
	public static string Cat1AppPainting05MuseumName = "Art Institute of Chicago";
	public static string Cat1AppPainting05MuseumLocation = "Chicago, Illinois, United States of America";
	public static string Cat1AppPainting05ARPieceName1 = "Diner";
	public static string Cat1AppPainting05ARPieceDescription1 = "xxxxxxxx";
	public static string Cat1AppPainting05ARPieceName2 = "Street";
	public static string Cat1AppPainting05ARPieceDescription2 = "xxxxxxxx";
	public static string Cat1AppPainting05ARPieceName3 = "Soda Fountains";
	public static string Cat1AppPainting05ARPieceDescription3 = "xxxxxxxx";

	// Individual Painting Information - Cat1AppPainting06
	public static string Cat1AppPainting06Name = "Ophelia";
	public static string Cat1AppPainting06Artist = "John Everett Millais";
	public static string Cat1AppPainting06GalleryName = "Art of Britain & America";
	public static int Cat1AppPainting06GalleryNumber = 1;
	public static string Cat1AppPainting06Movement = "Modernism";
	public static string Cat1AppPainting06Origintation = "Ewell, United Kingdom";
	public static string Cat1AppPainting06Nationality = "English";
	public static string Cat1AppPainting06Date = "1852";
	public static string Cat1AppPainting06MainDescription = "Like John William Waterhouse, Sir John Everett Millais was a member of the Pre-Raphaelite Brotherhood, which ultimately rejected the aesthetics and motifs of the Mannerist style, which was an art movement after the Renaissance went away from the technique and aesthetics of Raphael Sanzio. With works such as his Ophelia, The Order of Release, and Mariana, Millais sought to composed realistic renderings of figures and especially of the natural world. Representing the young singer before drowning in the river during the Shakespearean play, Hamlet, Sir John Everett Millais' Ophelia shows the true beauty within the natural landscape surrounding the young woman. Known for its realistic rendered of the land and its fictional accuracy of the scene, Ophelia has become one of the most iconic paintings of the 19th Century, even gathering praise and acclaim from both Salvador Dalí as well as the nation of Japan.";
	public static string Cat1AppPainting06MuseumName = "Tate Museum";
	public static string Cat1AppPainting06MuseumLocation = "London, United Kingdom";
	public static string Cat1AppPainting06ARPieceName1 = "River";
	public static string Cat1AppPainting06ARPieceDescription1 = "xxxxxxxx";
	public static string Cat1AppPainting06ARPieceName2 = "Flowers";
	public static string Cat1AppPainting06ARPieceDescription2 = "xxxxxxxx";
	public static string Cat1AppPainting06ARPieceName3 = "Riverbank";
	public static string Cat1AppPainting06ARPieceDescription3 = "xxxxxxxx";

// ********************************************* GALLERY CAT 2 *********************************************
	// Main Gallery Information
	public static string AppGalleryName2 = "Art of the Italian Peninsula";
	public static string AppGalleryDescription2 = "When art is brought up in conversation, the European nation of Italy is typically at the forefront of the conversation. With its plethora of masters and unknown number of grand works, Italy boasts itself as one of the capitals of the fine art world, in particular with pieces composed during two of the most artistic movements of all time: the Renaissance and Baroque Eras." + "\n" + "\n" + "The Renaissance Age was a time, mostly known throughout Europe, that occurred during the 14th and 17th Centuries. It lies between the Middle Ages and the Baroque Age. Literally meaning rebirth, the Renaissance was a rebirth of Classical antiquity, allowing artists, writers, poets, scholars, scientists, and philosophers to study and pay homage to their ancient ancestors. During this time, artists were known for painting and sculpting works of Greco-Roman mythology or narratives from the Bible that showcased both cultural themes as well as themes of Christianity." + "\n" + "\n" + "After the Renaissance Age, Baroque art was encouraged and influenced by the Catholic Church and the Counter Reformation to bring citizens back to Catholicism from the simple and austere Protestantism. Baroque art tended to be highly decorative and extravagant, creating dramatic scenes and vivid narratives through its painting and sculpture." + "\n" + "\n" + "The artists featured in the Art of the Italian Peninsula Gallery include Sandro Botticelli, Caravaggio, Giotto, Michelangelo, Raphael Sanzio, Giorgio Vasari, and Leonardo da Vinci.";

	// Individual Painting Information - Cat2AppPainting01
	public static string Cat2AppPainting01Name = "Birth of Venus";
	public static string Cat2AppPainting01Artist = "Sandro Botticelli";
	public static string Cat2AppPainting01GalleryName = "Art of the Italian Peninsula";
	public static int Cat2AppPainting01GalleryNumber = 2;
	public static string Cat2AppPainting01Movement = "Renaissance";
	public static string Cat2AppPainting01Origintation = "Florence, Italy";
	public static string Cat2AppPainting01Nationality = "Italian";
	public static string Cat2AppPainting01Date = "1485";
	public static string Cat2AppPainting01MainDescription = "Born in Florence, Sandro Botticelli was predominantly a painter during the Italian Renaissance. He is known mostly for being under the patronage of Lorenzo de Medici, also known as Lorenzo the Magnificent. To be an art patron means that you commission artists to complete works of art for a specific task, either for a family home, a church chapel, or a plaza sculpture as examples. Most of the time, these commissioned works represent characteristics and traits of the patron and his/her family. In this case, Botticelli's paintings revolved around the famous Medici family of Florence. Some of his more famous works include his Primavera and his Birth of Venus. The Birth of Venus​ is one of the most iconic paintings of the Italian Renaissance, showing the goddess, Venus, being born out of a seashell from the ocean. Painted by Sandro Botticelli in 1485, the God of Wind, Zephyr, blows the wind that carries Venus ashore. The nude figure is about to be covered by one of the Horae, Greek goddesses of Hours, representing the seasons and passing of time. The pink, floral robe she carries alludes to her being the Hora of Spring, which adds a symbolic connection to the Birth of Venus's 'sister' painting: Primavera. Art historians for decades have been decoding and analyzing the symbolic messages and meanings behind Botticelli's Birth of Venus and his Primavera, finding connections between the two. Both of which are well known throughout the art realm, comparable to Michelangelo's Sistine Chapel Ceiling and da Vinci's Mona Lisa.";
	public static string Cat2AppPainting01MuseumName = "Uffizi Gallery";
	public static string Cat2AppPainting01MuseumLocation = "Florence, Italy";
	public static string Cat2AppPainting01ARPieceName1 = "Seashell";
	public static string Cat2AppPainting01ARPieceDescription1 = "xxxxxxxx";
	public static string Cat2AppPainting01ARPieceName2 = "Floral Drapery";
	public static string Cat2AppPainting01ARPieceDescription2 = "xxxxxxxx";
	public static string Cat2AppPainting01ARPieceName3 = "Trees";
	public static string Cat2AppPainting01ARPieceDescription3 = "xxxxxxxx";
	public static string Cat2AppPainting01ARPieceName4 = "Wind";
	public static string Cat2AppPainting01ARPieceDescription4 = "xxxxxxxx";

	// Individual Painting Information - Cat2AppPainting02
	public static string Cat2AppPainting02Name = "Cardsharps";
	public static string Cat2AppPainting02Artist = "Caravaggio";
	public static string Cat2AppPainting02GalleryName = "Art of the Italian Peninsula";
	public static int Cat2AppPainting02GalleryNumber = 2;
	public static string Cat2AppPainting02Movement = "Baroque";
	public static string Cat2AppPainting02Origintation = "Rome, Italy";
	public static string Cat2AppPainting02Nationality = "Italian";
	public static string Cat2AppPainting02Date = "1594";
	public static string Cat2AppPainting02MainDescription = "Better known as just Caravaggio, Michelangelo Merisi da Caravaggio rivaled the Carracci Brothers and their Academy for setting the aesthetic tone of Baroque art. His grand canvases were not only realistic in depicting figures, objects, and nature, but also dove into a person's emotion and soul. Caravaggio used the element of chiaroscuro, which is the technique to paint extreme light tones with extreme dark tones for a dramatic contrast to express highly-dramatic and emotional scenes within his paintings. His drama and captivating grandeur can be seen within his Crucifixion of Saint Peter, Judith Beheading Holofernes, and the Calling of Saint Matthew. As one who uses skill or deception to win at card games, a card sharp/shark fools unsuspecting victims in these poker games to rob them of their money. Caravaggio brings this instigation to life within his 1594 painting, Cardsharps. Here, a well-dressed, wealthy young man in black and brown is seen looking down at the cards in his hand. Unbeknownst to him, the two other men around him are using trickery to rob him of his money. The figure behind the wealthy victim is holding up two fingers as a sign to his accomplice. The viewer can see the back of the accomplice, yet the victim cannot. The figure in front draws cards from behind his back, ready to play and 'win' the card game. Caravaggio adds a hint of drama and tension by depicting a small dagger on the left side of the front figure. Cardsharps as well as The Fortune Teller were a pair of Caravaggio's paintings that helped raise his reputation to the art world, showing street scenes of the Italian country.";
	public static string Cat2AppPainting02MuseumName = "Kimbell Art Museum";
	public static string Cat2AppPainting02MuseumLocation = "Fort Worth, Texas, United States of America";
	public static string Cat2AppPainting02ARPieceName1 = "Cards";
	public static string Cat2AppPainting02ARPieceDescription1 = "xxxxxxxx";
	public static string Cat2AppPainting02ARPieceName2 = "Dagger";
	public static string Cat2AppPainting02ARPieceDescription2 = "xxxxxxxx";
	public static string Cat2AppPainting02ARPieceName3 = "Chess Piece";
	public static string Cat2AppPainting02ARPieceDescription3 = "xxxxxxxx";
	public static string Cat2AppPainting02ARPieceName4 = "Hat";
	public static string Cat2AppPainting02ARPieceDescription4 = "xxxxxxxx";

	// Individual Painting Information - Cat2AppPainting03
	public static string Cat2AppPainting03Name = "Lamentation";
	public static string Cat2AppPainting03Artist = "Giotto";
	public static string Cat2AppPainting03GalleryName = "Art of the Italian Peninsula";
	public static int Cat2AppPainting03GalleryNumber = 2;
	public static string Cat2AppPainting03Movement = "Renaissance";
	public static string Cat2AppPainting03Origintation = "Padua, Italy";
	public static string Cat2AppPainting03Nationality = "Italian";
	public static string Cat2AppPainting03Date = "1306";
	public static string Cat2AppPainting03MainDescription = "As one of the earliest Renaissance paintings, Giotto di Bondone, or more commonly known as just Giotto, was born in the Republic of Florence. Within the Arena Chapel in Padua, Giotto was commissioned to depict scenes of the life of the Virgin Mary as well as the life of Jesus Christ, and, as a whole, the pieces are known to be one of the supreme works of the early Renaissance. These frescoes include Giotto's Marriage of the Virgin, Lamentation, ​The Adoration of the Magi, and The Wedding at Cana. This biblical narrative helped spark one of the most universally-known art movements in history. Located within the Arena Chapel in Padua, Italy, Giotto di Bondone covered the walls with various panels to celebrate the lives of the Virgin Mary and Jesus Christ. His Lamentation is located on the north wall of the chapel in the lower row of panels, set between the Crucifixion and The Resurrection of Jesus. Within the story of Jesus' life, the scene of Lamentation is when Christ's body is taken off the crucifix and mourned before his burial. The main scene shows the grief of the Virgin Mary holding Jesus, which can also be seen within scenes of the Pieta meaning 'pity', and most-famously rendered by Michelangelo Buonarroti's Pieta. Within Giotto's Lamentation, viewers can see Christ's body being held by the Madonna as the pair are surrounded by saints, holy figures, and angels, who are flying in the blue sky.";
	public static string Cat2AppPainting03MuseumName = "Arena Chapel";
	public static string Cat2AppPainting03MuseumLocation = "Padua, Italy";
	public static string Cat2AppPainting03ARPieceName1 = "Blue Sky";
	public static string Cat2AppPainting03ARPieceDescription1 = "xxxxxxxx";
	public static string Cat2AppPainting03ARPieceName2 = "Tree";
	public static string Cat2AppPainting03ARPieceDescription2 = "xxxxxxxx";
	public static string Cat2AppPainting03ARPieceName3 = "Hill";
	public static string Cat2AppPainting03ARPieceDescription3 = "xxxxxxxx";

	// Individual Painting Information - Cat2AppPainting04
	public static string Cat2AppPainting04Name = "Last Judgment";
	public static string Cat2AppPainting04Artist = "Michelangelo";
	public static string Cat2AppPainting04GalleryName = "Art of the Italian Peninsula";
	public static int Cat2AppPainting04GalleryNumber = 2;
	public static string Cat2AppPainting04Movement = "Renaissance";
	public static string Cat2AppPainting04Origintation = "Vatican City, Vatican";
	public static string Cat2AppPainting04Nationality = "Italian";
	public static string Cat2AppPainting04Date = "1539";
	public static string Cat2AppPainting04MainDescription = "Michelangelo Buonarroti, or better known just as Michelangelo, was born in Caprese within the Florentine Republic. Given the nickname of Il Divino, or the Divine One, Michelangelo was known as a master sculptor, painter, architect, and poet of the Italian Renaissance. He is widely known for several works of art, which range from his Sistine Chapel Ceiling, Pieta, David, Last Judgment, and the Saint Peter's Basilica. These are just a few of the immense variety of works completed by Michelangelo that hold such influence and inspiration throughout the world of art and art history. Michelangelo Buonarroti's Last Judgment covers the entire wall behind the high altar within the Sistine Chapel in the Vatican. This biblical scene shows the Second Coming of Christ and the final hours of judgement by God of humankind. The very center of the large fresco, which is a type of painting that is composed as part of the wall, contains the Virgin Mary and Jesus Christ. The pair are surrounded by various angels and saints. Mary is looking down at the bottom-left of the canvas, where humans are being saved from the fate that is Hell. Christ appears to be looking in the bottom-right corner, toward Charon, who was the ferryman of the souls of the Underworld, as told in Dante Alighieri's Divine Comedy, ferrying souls across the River Styx as demons are pulling them back into the fiery depths of Hell. Popes after the death of Michelangelo thought the original nude figures, of which almost all 300 were nude in Michelangelo's original work, were too obscene, resulting in a process to paint drapery over the figures. In the late 1980s, however, the Vatican restored about half of the painting to its original glory, as intended by the artist.";
	public static string Cat2AppPainting04MuseumName = "Sistine Chapel";
	public static string Cat2AppPainting04MuseumLocation = "Vatican City, Vatican";
	public static string Cat2AppPainting04ARPieceName1 = "Cross";
	public static string Cat2AppPainting04ARPieceDescription1 = "xxxxxxxx";
	public static string Cat2AppPainting04ARPieceName2 = "Clouds";
	public static string Cat2AppPainting04ARPieceDescription2 = "xxxxxxxx";
	public static string Cat2AppPainting04ARPieceName3 = "Underworld";
	public static string Cat2AppPainting04ARPieceDescription3 = "xxxxxxxx";
	public static string Cat2AppPainting04ARPieceName4 = "Hills";
	public static string Cat2AppPainting04ARPieceDescription4 = "xxxxxxxx";

	// Individual Painting Information - Cat2AppPainting05
	public static string Cat2AppPainting05Name = "Mona Lisa";
	public static string Cat2AppPainting05Artist = "Leonardo da Vinci";
	public static string Cat2AppPainting05GalleryName = "Art of the Italian Peninsula";
	public static int Cat2AppPainting05GalleryNumber = 2;
	public static string Cat2AppPainting05Movement = "Renaissance";
	public static string Cat2AppPainting05Origintation = "Florence, Italy";
	public static string Cat2AppPainting05Nationality = "Italian";
	public static string Cat2AppPainting05Date = "1516";
	public static string Cat2AppPainting05MainDescription = "Born in the city of Vinci within the Florentine Republic, Leonardo da Vinci became a Jack-of-all-trades of the Italian Renaissance. In his life, he was a painter, sculptor, architect, inventor, scientist, anatomist, and engineer. Several blueprints and inventions by da Vinci inspired today's modern feats of engineering or transportation, including the parachute and tank. Many of his works of art include a plethora of artistic inventions, including point and atmospheric perspectives, which add visual depth to paintings as well as sfumato, which is the blurring of outlines between figures and the background. These can be seen within his Mona Lisa, Last Supper, and Lady with an Ermine. Having a value of over $650 million, she is the most talked about, analyzed, studied, copied, sung about, and written about woman in the art world. Leonardo da Vinci's Mona Lisa, for being one of, if not probably the most iconic paintings of all time, the canvas is a minuscule 21 inches wide by 30 inches high. Da Vinci's model in this painting was Lisa del Giocondo, wife of a silk merchant, Francesco. Her expression, the sfumato implemented, and even her hand positions have all been debated for their mysterious, intriguing, interesting qualities. She is also known as La Gioconda, harking back to the model for the Mona Lisa, Lisa del Giocondo. Each year, tens of millions of visitors flock to the Louvre Museum, the good majority of which go just to be able to have a glimpse of the most iconic painting in the art world.";
	public static string Cat2AppPainting05MuseumName = "Louvre Museum";
	public static string Cat2AppPainting05MuseumLocation = "Paris, France";
	public static string Cat2AppPainting05ARPieceName1 = "Road";
	public static string Cat2AppPainting05ARPieceDescription1 = "xxxxxxxx";
	public static string Cat2AppPainting05ARPieceName2 = "Landscape";
	public static string Cat2AppPainting05ARPieceDescription2 = "xxxxxxxx";
	public static string Cat2AppPainting05ARPieceName3 = "Bridge";
	public static string Cat2AppPainting05ARPieceDescription3 = "xxxxxxxx";
	public static string Cat2AppPainting05ARPieceName4 = "River";
	public static string Cat2AppPainting05ARPieceDescription4 = "xxxxxxxx";

	// Individual Painting Information - Cat2AppPainting06
	public static string Cat2AppPainting06Name = "Perseus and Andromeda";
	public static string Cat2AppPainting06Artist = "Giorgio Vasari";
	public static string Cat2AppPainting06GalleryName = "Art of the Italian Peninsula";
	public static int Cat2AppPainting06GalleryNumber = 2;
	public static string Cat2AppPainting06Movement = "Renaissance";
	public static string Cat2AppPainting06Origintation = "Florence, Italy";
	public static string Cat2AppPainting06Nationality = "Italian";
	public static string Cat2AppPainting06Date = "1572";
	public static string Cat2AppPainting06MainDescription = "Born in Tuscany and known as the first art historian, Giorgio Vasari became versed in painting and architecture before delving into history and maintaining detailed documentation of past and present artists. He composed a piece of writing titled The Lives of the Most Excellent Painters, Sculptors, and Architects that lists out techniques, works, influences, and patrons of various artists, much of which art historians use today to study and analyze these masterful works of art. According to mythology, the Ethiopian princess Andromeda was sent to be sacrificed to prevent the city from being destroyed by a grand monster of the sea. As other citizens can be seen fleeing and trying to escape the wrath of the beast, the hero of Persia, Perseus, can be seen rescuing the princess. Giorgio Vasari captures this gallant moment in his rendition of Perseus and Andromeda. Today, the two constellations Perseus and Andromeda can always be seen next to each other in the night sky.";
	public static string Cat2AppPainting06MuseumName = "Palazzo Vecchio Museum";
	public static string Cat2AppPainting06MuseumLocation = "Florence, Italy";
	public static string Cat2AppPainting06ARPieceName1 = "Rock";
	public static string Cat2AppPainting06ARPieceDescription1 = "xxxxxxxx";
	public static string Cat2AppPainting06ARPieceName2 = "Landscape";
	public static string Cat2AppPainting06ARPieceDescription2 = "xxxxxxxx";
	public static string Cat2AppPainting06ARPieceName3 = "Coast";
	public static string Cat2AppPainting06ARPieceDescription3 = "xxxxxxxx";

	// Individual Painting Information - Cat2AppPainting07
	public static string Cat2AppPainting07Name = "Primavera";
	public static string Cat2AppPainting07Artist = "Sandro Botticelli";
	public static string Cat2AppPainting07GalleryName = "Art of the Italian Peninsula";
	public static int Cat2AppPainting07GalleryNumber = 2;
	public static string Cat2AppPainting07Movement = "Renaissance";
	public static string Cat2AppPainting07Origintation = "Florence, Italy";
	public static string Cat2AppPainting07Nationality = "Italian";
	public static string Cat2AppPainting07Date = "1480";
	public static string Cat2AppPainting07MainDescription = "Born in Florence, Sandro Botticelli was predominantly a painter during the Italian Renaissance. He is known mostly for being under the patronage of Lorenzo de Medici, also known as Lorenzo the Magnificent. To be an art patron means that you commission artists to complete works of art for a specific task, either for a family home, a church chapel, or a plaza sculpture as examples. Most of the time, these commissioned works represent characteristics and traits of the patron and his/her family. In this case, Botticelli's paintings revolved around the famous Medici family of Florence. Some of his more famous works include his Primavera and his Birth of Venus. Italian for 'spring', Sandro Botticelli's Primavera is right up there with his Birth of Venus as two of the most iconic paintings in Western art. The artist depicts a plethora of mythological figures, including nymphs, zephyrs, Cupid, the Three Graces, and Venus. There is no one focal point within the painting, which allows the viewer to interpret a variety of messages, themes, and motifs within the painting. There have been various connections, both symbolically and visually, to the 'sister' painting of the Primavera: Botticelli's Birth of Venus. The Hora of Spring, or one of the Horae, or Hours, that are the personifications of time and the seasons, is one of those visual connections, as she makes an appearance within both paintings.";
	public static string Cat2AppPainting07MuseumName = "Uffizi Gallery";
	public static string Cat2AppPainting07MuseumLocation = "Florence, Italy";
	public static string Cat2AppPainting07ARPieceName1 = "Laurel Trees";
	public static string Cat2AppPainting07ARPieceDescription1 = "xxxxxxxx";
	public static string Cat2AppPainting07ARPieceName2 = "Flowers";
	public static string Cat2AppPainting07ARPieceDescription2 = "xxxxxxxx";
	public static string Cat2AppPainting07ARPieceName3 = "Oranges";
	public static string Cat2AppPainting07ARPieceDescription3 = "xxxxxxxx";
	public static string Cat2AppPainting07ARPieceName4 = "Chloris";
	public static string Cat2AppPainting07ARPieceDescription4 = "xxxxxxxx";

	// Individual Painting Information - Cat2AppPainting08
	public static string Cat2AppPainting08Name = "School of Athens";
	public static string Cat2AppPainting08Artist = "Raphael Sanzio";
	public static string Cat2AppPainting08GalleryName = "Art of the Italian Peninsula";
	public static int Cat2AppPainting08GalleryNumber = 2;
	public static string Cat2AppPainting08Movement = "Renaissance";
	public static string Cat2AppPainting08Origintation = "Vatican City, Vatican";
	public static string Cat2AppPainting08Nationality = "Italian";
	public static string Cat2AppPainting08Date = "1510";
	public static string Cat2AppPainting08MainDescription = "Raphael Sanzio, who, like Michelangelo, just goes by his first name, was born in the town of Urbino in the central portion on the Italian Peninsula. Although dying young at the age of 37, Raphael managed a rather large and robust artist workshop throughout his adult life. He is known for having a rivalry with Michelangelo, and is known for his serenity and harmony within not only his own character, but also within his works of art. Some of his more famous works include his School of Athens, The Wedding of the Virgin, and his Madonna of the Meadow. No one truly knows what caused his early death, but he is buried within the Pantheon in Rome. As one of the four paintings within the Stanza della Segnatura within the Apostolic Palace in the Vatican, Raphael Sanzio's School of Athens is one of the most iconic pieces by the artist. The four paintings, altogether, represent four virtues of the papacy and of the Catholic Church: ​Disputation of the Holy Sacrament represents theology, The Parnassus represents literature, The Cardinal Virtues represent temperance, and this particular work, his School of Athens, represents philosophy. Raphael depicts fellow artists as various Ancient Roman philosophers within this iconic embodiment of Renaissance art.";
	public static string Cat2AppPainting08MuseumName = "Apostolic Palace";
	public static string Cat2AppPainting08MuseumLocation = "Vatican City, Vatican";
	public static string Cat2AppPainting08ARPieceName1 = "Columns";
	public static string Cat2AppPainting08ARPieceDescription1 = "xxxxxxxx";
	public static string Cat2AppPainting08ARPieceName2 = "Vaulted Ceilings";
	public static string Cat2AppPainting08ARPieceDescription2 = "xxxxxxxx";
	public static string Cat2AppPainting08ARPieceName3 = "Sculptures";
	public static string Cat2AppPainting08ARPieceDescription3 = "xxxxxxxx";
	public static string Cat2AppPainting08ARPieceName4 = "Courtyard";
	public static string Cat2AppPainting08ARPieceDescription4 = "xxxxxxxx";

	// Individual Painting Information - Cat2AppPainting09
	public static string Cat2AppPainting09Name = "Torment of Saint Anthony";
	public static string Cat2AppPainting09Artist = "Michelangelo";
	public static string Cat2AppPainting09GalleryName = "Art of the Italian Peninsula";
	public static int Cat2AppPainting09GalleryNumber = 2;
	public static string Cat2AppPainting09Movement = "Renaissance";
	public static string Cat2AppPainting09Origintation = "Florence, Italy";
	public static string Cat2AppPainting09Nationality = "Italian";
	public static string Cat2AppPainting09Date = "1487";
	public static string Cat2AppPainting09MainDescription = "Michelangelo Buonarroti, or better known just as Michelangelo, was born in Caprese within the Florentine Republic. Given the nickname of Il Divino, or the Divine One, Michelangelo was known as a master sculptor, painter, architect, and poet of the Italian Renaissance. He is widely known for several works of art, which range from his Sistine Chapel Ceiling, Pieta, David, Last Judgment, and the Saint Peter's Basilica. These are just a few of the immense variety of works completed by Michelangelo that hold such influence and inspiration throughout the world of art and art history. Also known as the Temptation of Saint Anthony, Michelangelo Buonarroti's Torment of Saint Anthony is one of the artist's earliest paintings of his career. Depicting the scene of the life of Saint Anthony when he was tormented and tried by demons while traveling through the desert, Michelangelo shows the saint airborne and surrounded by the attacking demons. The painting was originally attributed to Michelangelo's master at the time, Domenico Ghirlandaio. However, a note by one of the first art historians, Giorgio Vasari, helped to identify not as Ghirlandaio's piece, but by his apprentice, Michelangelo.";
	public static string Cat2AppPainting09MuseumName = "Kimbell Art Museum";
	public static string Cat2AppPainting09MuseumLocation = "Fort Worth, Texas, United States of America";
	public static string Cat2AppPainting09ARPieceName1 = "River";
	public static string Cat2AppPainting09ARPieceDescription1 = "xxxxxxxx";
	public static string Cat2AppPainting09ARPieceName2 = "Rocks";
	public static string Cat2AppPainting09ARPieceDescription2 = "xxxxxxxx";
	public static string Cat2AppPainting09ARPieceName3 = "Ship";
	public static string Cat2AppPainting09ARPieceDescription3 = "xxxxxxxx";
	public static string Cat2AppPainting09ARPieceName4 = "Coastal City";
	public static string Cat2AppPainting09ARPieceDescription4 = "xxxxxxxx";

// ********************************************* GALLERY CAT 3 *********************************************
	// Main Gallery Information
	public static string AppGalleryName3 = "Art of the East";
	public static string AppGalleryDescription3 = "Chinese and Japanese artists have been composing gorgeous masterpieces for at least the last three thousand years. Art of the East is vastly different than that of the Western world, specifically in content and emphasis. Eastern art typically tends to focus on the serenity and calmness of the land, showcasing the worldly balance and harmony between nature and man. This harmony can be seen throughout time, from Dynastic China to the Edo Period in Japan." + "\n" + "\n" + "During the golden age of Chinese history, the Tang and Song Dynasties had art that focused predominantly on landscape and nature. From 618 to 1279, the paintings from this stretch of time showcased the rhythm of nature as well as intimate, romantic scenes of the land as they became featured in large, monochromatic works." + "\n" + "\n" + "Also known as both the Tokugawa Period and Nanga, the Edo Period in Japan focused on more of the rhythm of nature rather than its realism. During this time, artists studied sciences and various Western techniques, ultimately culminating in the ukiyo-e genre of art. Subjects included landscapes, women, historical events, and nature, becoming known as pictures of the floating world." + "\n" + "\n" + "The artists featured in the Art of the East Gallery include Katsushika Hokusai, Tensho Shubun, Tomioka Tessai, Wang Wei, and Zhang Zeduan.";

	// Individual Painting Information - Cat3AppPainting01
	public static string Cat3AppPainting01Name = "Along the River During the Qingming Festival";
	public static string Cat3AppPainting01Artist = "Zhang Zeduan";
	public static string Cat3AppPainting01GalleryName = "Art of the East";
	public static int Cat3AppPainting01GalleryNumber = 3;
	public static string Cat3AppPainting01Movement = "Song Dynasty";
	public static string Cat3AppPainting01Origintation = "Kaifeng, China";
	public static string Cat3AppPainting01Nationality = "Chinese";
	public static string Cat3AppPainting01Date = "1145";
	public static string Cat3AppPainting01MainDescription = "Living between the transition from the Northern Song to the Southern Song Dynasties, Chinese painter Zhang Zeduan was instrumental in the art of the time. Known for his shan shui style, which refers to the depiction of scenic landscapes and the natural surrounding of the Chinese land using a brush and ink as opposed to color oil or tempera paints, he is prominently known for the large panorama, Along the River During the Qingming Festival. As a full landscape panorama of the Chinese land and people in Bianjing, Zhang Zeduan's Along the River During the Qingming Festival epitomizes the lush serenity of the land and the people that live amongst it. The Qingming Festival was a time of prayer and tomb sweeping, celebrating the festive spirit of the world. Here, the long painting shows the serene, respectful interaction between mankind and nature, keeping the pristine, elegant aspects of the Chinese landscape.";
	public static string Cat3AppPainting01MuseumName = "Palace Museum";
	public static string Cat3AppPainting01MuseumLocation = "Beijing, China";
	public static string Cat3AppPainting01ARPieceName1 = "Palace";
	public static string Cat3AppPainting01ARPieceDescription1 = "xxxxxxxx";
	public static string Cat3AppPainting01ARPieceName2 = "Wagons";
	public static string Cat3AppPainting01ARPieceDescription2 = "xxxxxxxx";
	public static string Cat3AppPainting01ARPieceName3 = "Building";
	public static string Cat3AppPainting01ARPieceDescription3 = "xxxxxxxx";

	// Individual Painting Information - Cat3AppPainting02
	public static string Cat3AppPainting02Name = "Festival of Lanterns on Temma Bridge, The";
	public static string Cat3AppPainting02Artist = "Katsushika Hokusai";
	public static string Cat3AppPainting02GalleryName = "Art of the East";
	public static int Cat3AppPainting02GalleryNumber = 3;
	public static string Cat3AppPainting02Movement = "Edo";
	public static string Cat3AppPainting02Origintation = "Tokyo, Japan";
	public static string Cat3AppPainting02Nationality = "Japanese";
	public static string Cat3AppPainting02Date = "1834";
	public static string Cat3AppPainting02MainDescription = "Katsushika Hokusai was a preeminent artist of the Edo Age and of the ukiyo-e style of art. Born in what is now Tokyo, Hokusai was known for his woodblock print works, highlighting both his appeal to nature and to Mount Fuji as well as a travel-inspired visual guide. Works such as The Dream of the Fisherman's Wife, Cuckoo and Azaleas, and his iconic Great Wave off Kanagawa appeal to both nature and worldly travel, inspiring viewers of his art to be one with the world. Senses of calmness, serenity, and tenderness can be felt within the paintings and print works of Hokusai. Having a history of over a millennium, the lantern festival in Osaka, Japan, is rich in tradition, culture, and symbolism. In 1834, Katsushika Hokusai represents that illuminating celebration with The Festival of Lanterns on Temma Bridge. Here, Hokusai depicts the iconic Temma Bridge, spanning the Osaka River as it flows through the Japanese island of Honshu. Boats travel as a processional down the river, carrying an assortment of lanterns. Hokusai depicts the lanterns also lighting across the Temma Bridge, as well as highlights the city of Osaka in the background on either bank of the river. This Edo painting truly highlights a 'picture of the floating world', representing the iconic and tradition-rich festival that occurs on Temma Bridge.";
	public static string Cat3AppPainting02MuseumName = "Brooklyn Museum";
	public static string Cat3AppPainting02MuseumLocation = "New York City, New York, United States of America";
	public static string Cat3AppPainting02ARPieceName1 = "Bridge";
	public static string Cat3AppPainting02ARPieceDescription1 = "xxxxxxxx";
	public static string Cat3AppPainting02ARPieceName2 = "Lantern";
	public static string Cat3AppPainting02ARPieceDescription2 = "xxxxxxxx";
	public static string Cat3AppPainting02ARPieceName3 = "Ship";
	public static string Cat3AppPainting02ARPieceDescription3 = "xxxxxxxx";
	public static string Cat3AppPainting02ARPieceName4 = "Coastal City";
	public static string Cat3AppPainting02ARPieceDescription4 = "xxxxxxxx";

	// Individual Painting Information - Cat3AppPainting03
	public static string Cat3AppPainting03Name = "Great Wave off Kanagawa, The";
	public static string Cat3AppPainting03Artist = "Katsushika Hokusai";
	public static string Cat3AppPainting03GalleryName = "Art of the East";
	public static int Cat3AppPainting03GalleryNumber = 3;
	public static string Cat3AppPainting03Movement = "Edo";
	public static string Cat3AppPainting03Origintation = "Tokyo, Japan";
	public static string Cat3AppPainting03Nationality = "Japanese";
	public static string Cat3AppPainting03Date = "1831";
	public static string Cat3AppPainting03MainDescription = "Katsushika Hokusai was a preeminent artist of the Edo Age and of the ukiyo-e style of art. Born in what is now Tokyo, Hokusai was known for his woodblock print works, highlighting both his appeal to nature and to Mount Fuji as well as a travel-inspired visual guide. Works such as The Dream of the Fisherman's Wife, Cuckoo and Azaleas, and his iconic Great Wave off Kanagawa appeal to both nature and worldly travel, inspiring viewers of his art to be one with the world. Senses of calmness, serenity, and tenderness can be felt within the paintings and print works of Hokusai. The Great Wave off Kanagawa is one of the most iconic and recognizable paintings in Japanese and even in Asian art history. There are several of these woodblock prints located throughout Western museums, including the Metropolitan Museum of Art, the National Gallery of Victoria, and this particular version, which is in the Art Institute of Chicago Building. Katsushika Hokusai's painting depicts a large tidal wave that threatens to overturn boats that are sailing off the coast of Kanagawa, which is present-day Yokohama, Japan. Due to the location near Kanagawa as well as the artist's fascination with the iconic mountain, Mount Fuji can be seen within the background of the painting.";
	public static string Cat3AppPainting03MuseumName = "Art Institute of Chicago";
	public static string Cat3AppPainting03MuseumLocation = "Chicago, Illinois, United States of America";
	public static string Cat3AppPainting03ARPieceName1 = "Wave";
	public static string Cat3AppPainting03ARPieceDescription1 = "xxxxxxxx";
	public static string Cat3AppPainting03ARPieceName2 = "Mount Fuji";
	public static string Cat3AppPainting03ARPieceDescription2 = "xxxxxxxx";
	public static string Cat3AppPainting03ARPieceName3 = "Ships";
	public static string Cat3AppPainting03ARPieceDescription3 = "xxxxxxxx";

	// Individual Painting Information - Cat3AppPainting04
	public static string Cat3AppPainting04Name = "Landscape of the Four Seasons";
	public static string Cat3AppPainting04Artist = "Tensho Shubun";
	public static string Cat3AppPainting04GalleryName = "Art of the East";
	public static int Cat3AppPainting04GalleryNumber = 3;
	public static string Cat3AppPainting04Movement = "Muromachi";
	public static string Cat3AppPainting04Origintation = "Kyoto, Japan";
	public static string Cat3AppPainting04Nationality = "Japanese";
	public static string Cat3AppPainting04Date = "1460";
	public static string Cat3AppPainting04MainDescription = "Tensho Shubun was a Zen Buddhist monk of the Muromachi Age of art in Japan. As the founder of the Chinese style of suiboku ink painting, which is a style of ink wash painting that blends natural depictions with calligraphic techniques, Shubun also taught well-known painter Sesshu Toyo. Influenced by the Chinese art of Xia Gui and Ma Yuan, Shubun's technical ink paintings contain a Zen-like feeling of calmness and serenity, as seen within his ​Landscape of the Four Seasons and his Reading in a Bamboo Grove​. This six-folded screen canvas painting was composed by Tensho Shubun at around 1460. The Landscape of the Four Seasons has been represented within various paintings by Japanese artists throughout the Muromachi Age of art. In this version, Shubun depicts a panoramic view of the landscape, complete will hilly terrain, mountains, a Japanese pagoda, trees, canoes, and cliff faces. Although not necessarily the four seasons of winter, spring, summer, and autumn, Shubun's Landscape of the Four Seasons showcases the multitude of natural landforms that span across the country of Japan, creating an overall-calm and serene feeling when viewing this ink wash painting.";
	public static string Cat3AppPainting04MuseumName = "Tokyo National Museum";
	public static string Cat3AppPainting04MuseumLocation = "Tokyo, Japan";
	public static string Cat3AppPainting04ARPieceName1 = "Trees";
	public static string Cat3AppPainting04ARPieceDescription1 = "xxxxxxxx";
	public static string Cat3AppPainting04ARPieceName2 = "Mountain";
	public static string Cat3AppPainting04ARPieceDescription2 = "xxxxxxxx";
	public static string Cat3AppPainting04ARPieceName3 = "House";
	public static string Cat3AppPainting04ARPieceDescription3 = "xxxxxxxx";
	public static string Cat3AppPainting04ARPieceName4 = "Canoe";
	public static string Cat3AppPainting04ARPieceDescription4 = "xxxxxxxx";
	public static string Cat3AppPainting04ARPieceName5 = "Coast";
	public static string Cat3AppPainting04ARPieceDescription5 = "xxxxxxxx";

	// Individual Painting Information - Cat3AppPainting05
	public static string Cat3AppPainting05Name = "Mountain of Immortals";
	public static string Cat3AppPainting05Artist = "Tomioka Tessai";
	public static string Cat3AppPainting05GalleryName = "Art of the East";
	public static int Cat3AppPainting05GalleryNumber = 3;
	public static string Cat3AppPainting05Movement = "Bunjinga";
	public static string Cat3AppPainting05Origintation = "Kyoto, Japan";
	public static string Cat3AppPainting05Nationality = "Japanese";
	public static string Cat3AppPainting05Date = "1924";
	public static string Cat3AppPainting05MainDescription = "Born in Kyoto in 1837, Tomioka Tessai was a painter and calligrapher, and was the last known artist of the Bunjinga Age of art in Japan. As a scholar and Shinto priest, Tessai's knowledge and influence were highlighted within his extreme detail and naturalistic flow of ink within his paintings. It is estimated that Tessai composed over 20,000 ink paintings in his life, including as much as 60 or 70 in a single day. These masterful, fluid ink paintings include his Two Divinities Dancing, Mountain of Immortals, Taoist Immortals Celebrating Longevity, and his Embarking on a Raft. Also known as ​Mount Penglai, Tomioka Tessai's Mountain of Immortals showcases the grandeur and pristine nature of the Japanese landscape. The lush greenery that caps the land is seen including white flowers, comparable to the iconic cherry blossoms of the Japanese land, as well as structures that add to the beauty of the landscape, as opposed of detracting from it. The bottom left and central portions of the canvas holds a small stream, calmly flowing against the banks of the mountainside. Within this Bunjinga style of art, Tessai exhibits the idyllic vision of nature that is captured so vividly within Japanese art.";
	public static string Cat3AppPainting05MuseumName = "Adachi Museum of Art";
	public static string Cat3AppPainting05MuseumLocation = "Yasugi, Japan";
	public static string Cat3AppPainting05ARPieceName1 = "Town";
	public static string Cat3AppPainting05ARPieceDescription1 = "xxxxxxxx";
	public static string Cat3AppPainting05ARPieceName2 = "Mountain";
	public static string Cat3AppPainting05ARPieceDescription2 = "xxxxxxxx";
	public static string Cat3AppPainting05ARPieceName3 = "Cherry Blossoms";
	public static string Cat3AppPainting05ARPieceDescription3 = "xxxxxxxx";
	public static string Cat3AppPainting05ARPieceName4 = "Coast";
	public static string Cat3AppPainting05ARPieceDescription4 = "xxxxxxxx";

	// Individual Painting Information - Cat3AppPainting06
	public static string Cat3AppPainting06Name = "Snowy Stream";
	public static string Cat3AppPainting06Artist = "Wang Wei";
	public static string Cat3AppPainting06GalleryName = "Art of the East";
	public static int Cat3AppPainting06GalleryNumber = 3;
	public static string Cat3AppPainting06Movement = "Tang Dynasty";
	public static string Cat3AppPainting06Origintation = "Xi'An, China";
	public static string Cat3AppPainting06Nationality = "Chinese";
	public static string Cat3AppPainting06Date = "735";
	public static string Cat3AppPainting06MainDescription = "Known as one of the most famous men of art and writing during the Tang Dynasty, Wang Wei is regarded as being the founder of the Southern School of Chinese Landscape Painting. The style and aesthetic of this school, and that of Wang Wei's, was one that constituted of strong brushstrokes in addition to lightly-toned ink washes. This developed a unique visual that blended painting and ink washing, which can be seen within his Snowy Stream and his Fu Sheng Expounding the Classic. Created for a hand scroll, this ink wash on silk painting by Wang Wei highlights the calmness and serenity of a winter landscape in China during the Tang Dynasty. Snowy Stream depicts a couple small houses surrounded by dense snowfall. A footbridge in the foreground helps to invite the viewer into the scene, adding a visual pathway that draws viewers into the winter wonderland. In the background, a small Chinese vessel can be seen floating on the calm waters that reside between the snow-covered lands.";
	public static string Cat3AppPainting06MuseumName = "Formerly Manchu Household Collection";
	public static string Cat3AppPainting06MuseumLocation = "Beijing, China";
	public static string Cat3AppPainting06ARPieceName1 = "House";
	public static string Cat3AppPainting06ARPieceDescription1 = "xxxxxxxx";
	public static string Cat3AppPainting06ARPieceName2 = "Bridge";
	public static string Cat3AppPainting06ARPieceDescription2 = "xxxxxxxx";
	public static string Cat3AppPainting06ARPieceName3 = "Stream";
	public static string Cat3AppPainting06ARPieceDescription3 = "xxxxxxxx";
	public static string Cat3AppPainting06ARPieceName4 = "Snow";
	public static string Cat3AppPainting06ARPieceDescription4 = "xxxxxxxx";

// ********************************************* GALLERY CAT 4 *********************************************
	// Main Gallery Information
	public static string AppGalleryName4 = "Art of the Netherlands";
	public static string AppGalleryDescription4 = "The Dutch were revered for their innovations and advances in society, especially during the 14th and 15th Centuries. From the establishment of a banking system, to a strong middle class, to a powerful naval force, the Dutch were able to create unique experiences for their citizens throughout time, which highly influenced Dutch art and artists. From the Dutch Golden Age to the time of Impressionism and Post-Impressionism, art from the Netherlands continues to be studied and collected for its prestige, prowess, and uniqueness." + "\n" + "\n" + "The Dutch Golden Age spanned the 17th Century in the Netherlands. During this time, the Dutch economy and culture was flourishing due to their rise in maritime trading, banking system, and rise of the middle class. The aesthetics of the Golden Age followed the Baroque Age of art, however the content of most works revolved around genre, everyday scenes of Dutch society." + "\n" + "\n" + "Impressionism was characterized by extremely loose brushstrokes that were visible throughout the entire painting. This 19th-Century art movement took landscapes, figures, and objects and incorporated both movement and emotion. Impressionism, in a matter of style, was almost the blending between Cubism and Baroque art; that dramatic and emotional appeal of the Baroque mixed with the inclusion of motion and the passing of time of Cubism." + "\n" + "\n" + "As a subset of Impressionism, Post-Impressionism (also spelled Postimpressionism) was mostly a French movement toward the end of the 19th Century. As a way to counter the Impressionist use of naturalism in their light and color, Post-Impressionist artists used a more abstract color palette, where the colors were more symbolic than natural." + "\n" + "\n" + "The artists featured in the Art of the Netherlands Gallery include Pieter Bruegel the Elder, Jan van Eyck. Vincent van Gogh, Piet Mondrian, Rembrandt van Rijn, Jacob van Ruisdael, and Johannes Vermeer.";

	// Individual Painting Information - Cat4AppPainting01
	public static string Cat4AppPainting01Name = "Allegory of Painting, The";
	public static string Cat4AppPainting01Artist = "Johannes Vermeer";
	public static string Cat4AppPainting01GalleryName = "Art of the Netherlands";
	public static int Cat4AppPainting01GalleryNumber = 4;
	public static string Cat4AppPainting01Movement = "Golden Age";
	public static string Cat4AppPainting01Origintation = "Delft, Netherlands";
	public static string Cat4AppPainting01Nationality = "Dutch";
	public static string Cat4AppPainting01Date = "1666";
	public static string Cat4AppPainting01MainDescription = "Dutch master Johannes Vermeer was born in Delft within the Dutch Republic, known for his cultural and everyday scenes of the Dutch society. Similar to the art of Jacob van Ruisdael, Vermeer expressed a sense of almost-hyper realism with his objects, scenes, and figures. Religion, poetry, music, and science are all allusions that can be found within his scenes, which range from noble society to scenes of everyday life. These paintings can include The Milkmaid, Girl with a Pearl Earring, and The Allegory of Painting. Also known as The Art of Painting, Vermeer's The Allegory of Painting shows an artist within a home or studio painting a young lady in a blue dress holding a book and a musical instrument. Vermeer frames the painting, allowing the viewer to appear as if they are inside the house behind the artist, watching the scene unfold. The map behind the girl is of the Low Countries of the Netherlands, giving a historical sense as well as the impression of art and artifact collecting to the culture of the Netherlands around the 1660s. The checkerboard floor pattern shows point perspective and depth within the painting, drawing the viewer's eyes back from the drapery on the left, to the artist and his canvas in the midground, to the young woman and the map in the background.";
	public static string Cat4AppPainting01MuseumName = "Kunsthistoriches Museum Wein";
	public static string Cat4AppPainting01MuseumLocation = "Vienna, Austria";
	public static string Cat4AppPainting01ARPieceName1 = "Map";
	public static string Cat4AppPainting01ARPieceDescription1 = "Vermeer exhibits his admiration for cartography within several of his paintings. From The Geographer and The Astronomer to The Allegory of Painting, the presence of maps within these interior scenes exhibits the Dutch curiosity during the Golden Age on expansion, preservation, antiquity, and knowledge. The particular map that hangs within The Allegory of Painting represents the seventeen provinces of the Netherlands, which was shown as several separate sheets stitched together to form the larger central portion. Around the perimeter of the map sits over a dozen views of the towns that make up the Netherlandish provinces. Vermeer's map, which is presumably based off a map created by Nicolas Visscher during the 1650s, portrays highly-decorative and detailed visual accounts of the geography and townships within the Dutch Republic, helping to revolutionize how modern-day geographers, astronomers, cartographers, and navigators comprehend both terrestrial and maritime travel." + "\n" + "\n" + "Welu, James. The Map in Vermeer's Art of Painting. In Imago Mundi. Taylor & Francis, Ltd: London, United Kingdom. 1978. 9-30.";
	public static string Cat4AppPainting01ARPieceName2 = "Easel";
	public static string Cat4AppPainting01ARPieceDescription2 = "The inclusion of an easel allows viewers to be a part of the scene rather than just looking upon the scene. Vermeer places us, the viewer, standing behind the artist who sits at his easel, getting to see exactly what the artist sees as he paints. During the time of the Golden Age in the Netherlands, easel painting was seen as a way of increasing the worth and value of artworks and the collection of them. Instead of painting on walls by way of frescoes, easel paintings were smaller in size. This allowed for the increase in collecting, giving rise to the independence of paintings as well as painting as a profession. Vermeer highlights the transition from large, commissioned paintings to artists becoming both more individual and professional." + "\n" + "\n" + "Powell, Amy. Painting as Blur: Landscapes in Paintings of the Dutch Interior. In Oxford Art Journal. Oxford University Press: Oxford, United Kingdom. 2010. 153-154.";
	public static string Cat4AppPainting01ARPieceName3 = "Curtain";
	public static string Cat4AppPainting01ARPieceDescription3 = "xxxxxxxx";
	public static string Cat4AppPainting01ARPieceName4 = "Desk";
	public static string Cat4AppPainting01ARPieceDescription4 = "xxxxxxxx";
	public static string Cat4AppPainting01ARPieceName5 = "Musical Instrument";
	public static string Cat4AppPainting01ARPieceDescription5 = "xxxxxxxx";

	// Individual Painting Information - Cat4AppPainting02
	public static string Cat4AppPainting02Name = "Arnolfini Portrait";
	public static string Cat4AppPainting02Artist = "Jan van Eyck";
	public static string Cat4AppPainting02GalleryName = "Art of the Netherlands";
	public static int Cat4AppPainting02GalleryNumber = 4;
	public static string Cat4AppPainting02Movement = "Golden Age";
	public static string Cat4AppPainting02Origintation = "Bruges, Belgium";
	public static string Cat4AppPainting02Nationality = "Dutch";
	public static string Cat4AppPainting02Date = "1434";
	public static string Cat4AppPainting02MainDescription = "Commissioned by the Duke of Burgundy, Philip the Good, Flemish painter Jan van Eyck was known for his panel paintings, canvas paintings, portraits, genre paintings, and even altarpieces. As one of the founders of the Dutch Golden Age of painting, van Eyck was able to paint until he was content with his composition, allowing him the freedom to implement an extremely realistic style and aesthetic within his paintings. With the new use of oils in his paintings, van Eyck gave the art world his Ghent Altarpiece, Arnolfini Portrait, and his ​Portrait of a Man. Said to be one of the first portraits commemorating a wedding, Jan van Eyck's Arnolfini Portrait shows Giovanni Arnolfini, a wealthy Italian merchant alongside his wife Costanza. Although painted one year after Costanza's death, the portrait might have a double interpretation, also as a representation of memorial for Giovanni's late bride.Van Eyck uses point perspective to create depth, as seen within the receding floorboards as well as within the lines on the window on the left side of the canvas. Upon closer inspection, the mirror on the back wall shows two figures: one is presumably the artist, Jan van Eyck. His Arnolfini Portrait is one of the first paintings to show the self-portrait of the painter while working on the particular artwork, a staple for later Dutch portrait paintings. The other figure in the mirror is unidentified, leaving it up to interpretation. However, van Eyck allows the viewer to appear they are next to the artist as he renders the scene, giving the illusion that the viewer is placed within the room as a part of the special, memorable occasion.";
	public static string Cat4AppPainting02MuseumName = "National Gallery";
	public static string Cat4AppPainting02MuseumLocation = "London, United Kingdom";
	public static string Cat4AppPainting02ARPieceName1 = "Mirror";
	public static string Cat4AppPainting02ARPieceDescription1 = "xxxxxxxx";
	public static string Cat4AppPainting02ARPieceName2 = "Dog";
	public static string Cat4AppPainting02ARPieceDescription2 = "xxxxxxxx";
	public static string Cat4AppPainting02ARPieceName3 = "Window";
	public static string Cat4AppPainting02ARPieceDescription3 = "xxxxxxxx";
	public static string Cat4AppPainting02ARPieceName4 = "Shoes";
	public static string Cat4AppPainting02ARPieceDescription4 = "xxxxxxxx";

	// Individual Painting Information - Cat4AppPainting03
	public static string Cat4AppPainting03Name = "Astronomer, The";
	public static string Cat4AppPainting03Artist = "Johannes Vermeer";
	public static string Cat4AppPainting03GalleryName = "Art of the Netherlands";
	public static int Cat4AppPainting03GalleryNumber = 4;
	public static string Cat4AppPainting03Movement = "Golden Age";
	public static string Cat4AppPainting03Origintation = "Delft, Netherlands";
	public static string Cat4AppPainting03Nationality = "Dutch";
	public static string Cat4AppPainting03Date = "1668";
	public static string Cat4AppPainting03MainDescription = "Dutch master Johannes Vermeer was born in Delft within the Dutch Republic, known for his cultural and everyday scenes of the Dutch society. Similar to the art of Jacob van Ruisdael, Vermeer expressed a sense of almost-hyper realism with his objects, scenes, and figures. Religion, poetry, music, and science are all allusions that can be found within his scenes, which range from noble society to scenes of everyday life. These paintings can include The Milkmaid, Girl with a Pearl Earring, and The Allegory of Painting. Comparable to The Geographer​, Johannes Vermeer composed The Astronomer within the same room, including the same visual elements such as the desk, window, shelving unit, and globe. Science was a fascination for Dutch Golden Age painters, and Vermeer highlights the science of astronomy within this particular painting. Some symbolism within the piece include the celestial globe being studied by the astronomer, the book on the table in front of the scientist, which is an institutional guide on astronomy, and the charts posted on the bookshelf in the background. Currently on display at the Louvre Museum, The Astronomer highlights the desire and passion for studying science, the blending of art and science within society and culture.";
	public static string Cat4AppPainting03MuseumName = "Louvre Museum";
	public static string Cat4AppPainting03MuseumLocation = "Paris, France";
	public static string Cat4AppPainting03ARPieceName1 = "Globe";
	public static string Cat4AppPainting03ARPieceDescription1 = "xxxxxxxx";
	public static string Cat4AppPainting03ARPieceName2 = "Curtain";
	public static string Cat4AppPainting03ARPieceDescription2 = "xxxxxxxx";
	public static string Cat4AppPainting03ARPieceName3 = "Clocks";
	public static string Cat4AppPainting03ARPieceDescription3 = "xxxxxxxx";
	public static string Cat4AppPainting03ARPieceName4 = "Books";
	public static string Cat4AppPainting03ARPieceDescription4 = "xxxxxxxx";

	// Individual Painting Information - Cat4AppPainting04
	public static string Cat4AppPainting04Name = "Café Terrace at Night";
	public static string Cat4AppPainting04Artist = "Vincent van Vogh";
	public static string Cat4AppPainting04GalleryName = "Art of the Netherlands";
	public static int Cat4AppPainting04GalleryNumber = 4;
	public static string Cat4AppPainting04Movement = "Post-Impressionism";
	public static string Cat4AppPainting04Origintation = "Arles, France";
	public static string Cat4AppPainting04Nationality = "Dutch";
	public static string Cat4AppPainting04Date = "1888";
	public static string Cat4AppPainting04MainDescription = "Vincent van Gogh was one of the most influential historical figures of Western art. Most of his artwork came in the last several years of his life, and included portraits, self-portraits, landscapes, and still-life paintings. His artworks were very expressive with the bright palette and the loose, painterly brushstrokes. Over 2,000 of his works of art became the influential and inspirational cornerstone for modern works of art, including his Still Life: Vase with Fourteen Sunflowers, The Night Café, and his Starry Night​. Also known as Café Terrace on the Place du Forum as well as ​Coffeehouse, in the Evening, Vincent van Gogh's Café Terrace at Night shows the street of the Place du Forum in Arles, France, in September, 1888. Visitors to the area can actually stand and face in the direction where van Gogh set up his canvas, which the area was remodeled in the early 1990s to visually replicate his painting. Van Gogh represents the cobblestone street, visitors of the café, as well as buildings and trees in the background. This is the first rendering of the night sky that van Gogh implements within his Starry Night over the Rhône as well as his iconic Starry Night. The description and passion by Vincent van Gogh have been detailed within letters of correspondence between him and his sister, Wil, as well as between him and his brother, Theo.";
	public static string Cat4AppPainting04MuseumName = "Kröller-Müller Museum";
	public static string Cat4AppPainting04MuseumLocation = "Otterlo, Netherlands";
	public static string Cat4AppPainting04ARPieceName1 = "Cobblestone Street";
	public static string Cat4AppPainting04ARPieceDescription1 = "xxxxxxxx";
	public static string Cat4AppPainting04ARPieceName2 = "Patio";
	public static string Cat4AppPainting04ARPieceDescription2 = "xxxxxxxx";
	public static string Cat4AppPainting04ARPieceName3 = "Stars";
	public static string Cat4AppPainting04ARPieceDescription3 = "xxxxxxxx";

	// Individual Painting Information - Cat4AppPainting05
	public static string Cat4AppPainting05Name = "Composition with Red, Blue, and Yellow";
	public static string Cat4AppPainting05Artist = "Piet Mondrian";
	public static string Cat4AppPainting05GalleryName = "Art of the Netherlands";
	public static int Cat4AppPainting05GalleryNumber = 4;
	public static string Cat4AppPainting05Movement = "Impressionism";
	public static string Cat4AppPainting05Origintation = "Paris, France";
	public static string Cat4AppPainting05Nationality = "Dutch";
	public static string Cat4AppPainting05Date = "1929";
	public static string Cat4AppPainting05MainDescription = "Dutch abstract artist Piet Mondrian was known as one of the most well-known artists of the 20th Century. Born in the Netherlands, Mondrian's career evolved into more and more abstract figures and objects, eventually culminating into simple geometric shapes with primary colors: essentially breaking down fine art into the building blocks of painting. Mondrian's artwork, which include his Composition with Red, Blue, and Yellow, Tableau I, and his Composition No. 10, not only influenced later Impressionist painters, but also realms outside of painting, including interior design, architecture, and fashion design. Piet Mondrian gave the art world his extremely abstract Composition with Red, Blue, and Yellow in 1929. Mondrian implemented the De Stijl style of art, which was actually co-formed by Mondrian, within this particular painting. De Stijl, which is Dutch for 'The Style', represents the absolute basic elements of art: form, line, and color. Within his Composition with Red, Blue, and Yellow, Mondrian renders the three primary colors, along with white and black, of red, blue, and yellow within the shapes. The forms and shapes of the painting are all rectangles and squares, two extremely primary, basic shapes of art and architecture. The lines within the painting do not contain any curves as they are all either completely vertical or completely horizontal.";
	public static string Cat4AppPainting05MuseumName = "Private Collection";
	public static string Cat4AppPainting05MuseumLocation = "Private Collection";
	public static string Cat4AppPainting05ARPieceName1 = "Red";
	public static string Cat4AppPainting05ARPieceDescription1 = "xxxxxxxx";
	public static string Cat4AppPainting05ARPieceName2 = "Blue";
	public static string Cat4AppPainting05ARPieceDescription2 = "xxxxxxxx";
	public static string Cat4AppPainting05ARPieceName3 = "Yellow";
	public static string Cat4AppPainting05ARPieceDescription3 = "xxxxxxxx";
	public static string Cat4AppPainting05ARPieceName4 = "White";
	public static string Cat4AppPainting05ARPieceDescription4 = "xxxxxxxx";
	public static string Cat4AppPainting05ARPieceName5 = "Black";
	public static string Cat4AppPainting05ARPieceDescription5 = "xxxxxxxx";

	// Individual Painting Information - Cat4AppPainting06
	public static string Cat4AppPainting06Name = "Geographer, The";
	public static string Cat4AppPainting06Artist = "Johannes Vermeer";
	public static string Cat4AppPainting06GalleryName = "Art of the Netherlands";
	public static int Cat4AppPainting06GalleryNumber = 4;
	public static string Cat4AppPainting06Movement = "Golden Age";
	public static string Cat4AppPainting06Origintation = "Delft, Netherlands";
	public static string Cat4AppPainting06Nationality = "Dutch";
	public static string Cat4AppPainting06Date = "1668";
	public static string Cat4AppPainting06MainDescription = "Dutch master Johannes Vermeer was born in Delft within the Dutch Republic, known for his cultural and everyday scenes of the Dutch society. Similar to the art of Jacob van Ruisdael, Vermeer expressed a sense of almost-hyper realism with his objects, scenes, and figures. Religion, poetry, music, and science are all allusions that can be found within his scenes, which range from noble society to scenes of everyday life. These paintings can include The Milkmaid, Girl with a Pearl Earring, and The Allegory of Painting. Johannes Vermeer's The Geographer is tied to its 'sister' painting, The Astronomer. In fact, this pair of paintings are two of the three to have been signed and dated by the artist, the third being The Procuress. The man appears to be in a contemplative state as he holds a compass in his hand. He is shown leaning over a table, which is covered by a large map. More maps can be seen strewn about the floor of the room, which is also the same room as seen within Vermeer's The Astronomer. This work of art highlights Vermeer's curious and inquisitive nature of studying the various sciences, blending the fields of science and art.";
	public static string Cat4AppPainting06MuseumName = "Städel Museum";
	public static string Cat4AppPainting06MuseumLocation = "Frankfurt, Germany";
	public static string Cat4AppPainting06ARPieceName1 = "Map";
	public static string Cat4AppPainting06ARPieceDescription1 = "xxxxxxxx";
	public static string Cat4AppPainting06ARPieceName2 = "Globe";
	public static string Cat4AppPainting06ARPieceDescription2 = "xxxxxxxx";
	public static string Cat4AppPainting06ARPieceName3 = "Curtain";
	public static string Cat4AppPainting06ARPieceDescription3 = "xxxxxxxx";
	public static string Cat4AppPainting06ARPieceName4 = "Papers";
	public static string Cat4AppPainting06ARPieceDescription4 = "xxxxxxxx";
	public static string Cat4AppPainting06ARPieceName5 = "Compass";
	public static string Cat4AppPainting06ARPieceDescription5 = "xxxxxxxx";

	// Individual Painting Information - Cat4AppPainting07
	public static string Cat4AppPainting07Name = "Ghent Altarpiece, The";
	public static string Cat4AppPainting07Artist = "Jan van Eyck";
	public static string Cat4AppPainting07GalleryName = "Art of the Netherlands";
	public static int Cat4AppPainting07GalleryNumber = 4;
	public static string Cat4AppPainting07Movement = "Golden Age";
	public static string Cat4AppPainting07Origintation = "Ghent, Belgium";
	public static string Cat4AppPainting07Nationality = "Dutch";
	public static string Cat4AppPainting07Date = "1432";
	public static string Cat4AppPainting07MainDescription = "Commissioned by the Duke of Burgundy, Philip the Good, Flemish painter Jan van Eyck was known for his panel paintings, canvas paintings, portraits, genre paintings, and even altarpieces. As one of the founders of the Dutch Golden Age of painting, van Eyck was able to paint until he was content with his composition, allowing him the freedom to implement an extremely realistic style and aesthetic within his paintings. With the new use of oils in his paintings, van Eyck gave the art world his Ghent Altarpiece, Arnolfini Portrait, and his ​Portrait of a Man. Also known as the Adoration of the Mystic Lamb, Jan van Eyck's Ghent Altarpiece is considered to be one of the greatest masterpieces of art and art history. The upper panel depicts Christ the King, Saint John the Baptist, and the Virgin Mary. Music-playing angels and figures adorn the panels in the upper row to the left and right of the central trio. On the outer panels in the upper row are the nude depictions of Adam and Eve. The bottom row of panels complete a large panoramic scene of the Adoration of the Lamb of God. Popularity of this masterful painting rose with the release of the movie The Monuments Men, as the Ghent Altarpiece plays an iconic role of art in its recovery during the movie as the panels were stolen by the Nazi Army during the Second World War.";
	public static string Cat4AppPainting07MuseumName = "Saint Bavo's Cathedral";
	public static string Cat4AppPainting07MuseumLocation = "Ghent, Belgium";
	public static string Cat4AppPainting07ARPieceName1 = "Throne";
	public static string Cat4AppPainting07ARPieceDescription1 = "xxxxxxxx";
	public static string Cat4AppPainting07ARPieceName2 = "Altar";
	public static string Cat4AppPainting07ARPieceDescription2 = "xxxxxxxx";
	public static string Cat4AppPainting07ARPieceName3 = "Panels";
	public static string Cat4AppPainting07ARPieceDescription3 = "xxxxxxxx";

	// Individual Painting Information - Cat4AppPainting08
	public static string Cat4AppPainting08Name = "Haystacks in Provence";
	public static string Cat4AppPainting08Artist = "Vincent van Gogh";
	public static string Cat4AppPainting08GalleryName = "Art of the Netherlands";
	public static int Cat4AppPainting08GalleryNumber = 4;
	public static string Cat4AppPainting08Movement = "Post-Impressionism";
	public static string Cat4AppPainting08Origintation = "Arles, France";
	public static string Cat4AppPainting08Nationality = "Dutch";
	public static string Cat4AppPainting08Date = "1888";
	public static string Cat4AppPainting08MainDescription = "Vincent van Gogh was one of the most influential historical figures of Western art. Most of his artwork came in the last several years of his life, and included portraits, self-portraits, landscapes, and still-life paintings. His artworks were very expressive with the bright palette and the loose, painterly brushstrokes. Over 2,000 of his works of art became the influential and inspirational cornerstone for modern works of art, including his Still Life: Vase with Fourteen Sunflowers, The Night Café, and his Starry Night​. In the final years of his career, Vincent van Gogh paints an enormous oeuvre of landscapes, pastorals, and cityscapes. His 1888 Haystacks in Provence is no exception to this trend, and it represents a pastoral, rural scene of large haystacks assembled in the countryside outside the region of Provence, France. The large, painterly brushstrokes seemingly guide the audience's eyes to the large haystacks in the center of the canvas, making them to main focal point of the piece before the viewer's eyes traverse throughout the rest of the painting.";
	public static string Cat4AppPainting08MuseumName = "Kröller-Müller Museum";
	public static string Cat4AppPainting08MuseumLocation = "Otterlo, Netherlands";
	public static string Cat4AppPainting08ARPieceName1 = "Haystack";
	public static string Cat4AppPainting08ARPieceDescription1 = "xxxxxxxx";
	public static string Cat4AppPainting08ARPieceName2 = "Ladder";
	public static string Cat4AppPainting08ARPieceDescription2 = "xxxxxxxx";
	public static string Cat4AppPainting08ARPieceName3 = "Town";
	public static string Cat4AppPainting08ARPieceDescription3 = "xxxxxxxx";
	public static string Cat4AppPainting08ARPieceName4 = "Cobblestone Street";
	public static string Cat4AppPainting08ARPieceDescription4 = "xxxxxxxx";

	// Individual Painting Information - Cat4AppPainting09
	public static string Cat4AppPainting09Name = "Irises";
	public static string Cat4AppPainting09Artist = "Vincent van Gogh";
	public static string Cat4AppPainting09GalleryName = "Art of the Netherlands";
	public static int Cat4AppPainting09GalleryNumber = 4;
	public static string Cat4AppPainting09Movement = "Post-Impressionism";
	public static string Cat4AppPainting09Origintation = "Arles, France";
	public static string Cat4AppPainting09Nationality = "Dutch";
	public static string Cat4AppPainting09Date = "1889";
	public static string Cat4AppPainting09MainDescription = "Vincent van Gogh was one of the most influential historical figures of Western art. Most of his artwork came in the last several years of his life, and included portraits, self-portraits, landscapes, and still-life paintings. His artworks were very expressive with the bright palette and the loose, painterly brushstrokes. Over 2,000 of his works of art became the influential and inspirational cornerstone for modern works of art, including his Still Life: Vase with Fourteen Sunflowers, The Night Café, and his Starry Night​. While a patient of the Saint-Rémy-de-Provence asylum, Vincent van Gogh painted Irises in May of 1889. The painting resembles flowers from the peaceful garden of the asylum, and the serene painting helped van Gogh cope with his emotional and mental instability. Van Gogh took inspiration from the Japanese ukiyo-e prints, including paintings by Katsushika Hokusai. Vincent's brother Theo said that the Irises were full of life, color, and air, which can visually be seen through the cool colors of the field of flowers.";
	public static string Cat4AppPainting09MuseumName = "J. Paul Getty Museum";
	public static string Cat4AppPainting09MuseumLocation = "Los Angeles, California, United States of America";
	public static string Cat4AppPainting09ARPieceName1 = "Irises";
	public static string Cat4AppPainting09ARPieceDescription1 = "xxxxxxxx";
	public static string Cat4AppPainting09ARPieceName2 = "Daisy";
	public static string Cat4AppPainting09ARPieceDescription2 = "xxxxxxxx";
	public static string Cat4AppPainting09ARPieceName3 = "Sunflowers";
	public static string Cat4AppPainting09ARPieceDescription3 = "xxxxxxxx";

	// Individual Painting Information - Cat4AppPainting10
	public static string Cat4AppPainting10Name = "Jewish Cemetery";
	public static string Cat4AppPainting10Artist = "Jacob van Ruisdael";
	public static string Cat4AppPainting10GalleryName = "Art of the Netherlands";
	public static int Cat4AppPainting10GalleryNumber = 4;
	public static string Cat4AppPainting10Movement = "Golden Age";
	public static string Cat4AppPainting10Origintation = "Alkmaar, Netherlands";
	public static string Cat4AppPainting10Nationality = "Dutch";
	public static string Cat4AppPainting10Date = "1650";
	public static string Cat4AppPainting10MainDescription = "As one of the prominent landscape painters of the Dutch Golden Age, Jacob van Ruisdael gave the art world an almost-hyper realistic aesthetic of painting. Van Ruisdael's paintings typically depicted atmosphere as the upper two-thirds of the canvas, which expressed motion, movement, and vivacity within his pieces. The extreme precision and detail within the clouds, land, and objects give the sense of a photographic appeal to viewers, making them feel as if a part of the scene. These include The Jewish Cemetery, Windmill at Wijk bij Duurstede, and A Wooded Marsh. Jacob van Ruisdael's Jewish Cemetery showcases the circle of life of nature. He depicts several tombs and graves within the foreground of the canvas amongst the broken tree limbs and grass. In the center of the painting rests a run-down cathedral, broken and dilapidated, yet still standing. The foreground of the scene represents death and the end of life in the fallen trees and tombs, yet the background shows life. In the back, van Ruisdael portrays lush greenery, sunlight raining down through the clouds, and even a faint rainbow. The running water travels from the back of the canvas to the front, implying that even though death is in the forefront of the scene, life is not far behind, thus completing the chain that is the circle of life.";
	public static string Cat4AppPainting10MuseumName = "Detroit Institute of Arts Museum";
	public static string Cat4AppPainting10MuseumLocation = "Detroit, Michigan, United States of America";
	public static string Cat4AppPainting10ARPieceName1 = "Ruins";
	public static string Cat4AppPainting10ARPieceDescription1 = "xxxxxxxx";
	public static string Cat4AppPainting10ARPieceName2 = "Tombs";
	public static string Cat4AppPainting10ARPieceDescription2 = "xxxxxxxx";
	public static string Cat4AppPainting10ARPieceName3 = "Dead Tree";
	public static string Cat4AppPainting10ARPieceDescription3 = "xxxxxxxx";
	public static string Cat4AppPainting10ARPieceName4 = "Rainbow";
	public static string Cat4AppPainting10ARPieceDescription4 = "xxxxxxxx";
	public static string Cat4AppPainting10ARPieceName5 = "Clouds";
	public static string Cat4AppPainting10ARPieceDescription5 = "xxxxxxxx";

	// Individual Painting Information - Cat4AppPainting11
	public static string Cat4AppPainting11Name = "Landscape with a Mill Run and Ruins";
	public static string Cat4AppPainting11Artist = "Jacob van Ruisdael";
	public static string Cat4AppPainting11GalleryName = "Art of the Netherlands";
	public static int Cat4AppPainting11GalleryNumber = 4;
	public static string Cat4AppPainting11Movement = "Golden Age";
	public static string Cat4AppPainting11Origintation = "Alkmaar, Netherlands";
	public static string Cat4AppPainting11Nationality = "Dutch";
	public static string Cat4AppPainting11Date = "1653";
	public static string Cat4AppPainting11MainDescription = "As one of the prominent landscape painters of the Dutch Golden Age, Jacob van Ruisdael gave the art world an almost-hyper realistic aesthetic of painting. Van Ruisdael's paintings typically depicted atmosphere as the upper two-thirds of the canvas, which expressed motion, movement, and vivacity within his pieces. The extreme precision and detail within the clouds, land, and objects give the sense of a photographic appeal to viewers, making them feel as if a part of the scene. These include The Jewish Cemetery, Windmill at Wijk bij Duurstede, and A Wooded Marsh. Characteristic of Jacob van Ruisdael's almost-hyper realistic technique, his Landscape with a Mill Run and Ruins combines the contrasting motifs of life and death into one complete painting. Here, the aspects of death can be seen within the ruins and overrun walls that are dispersed throughout the scene. However, the lushness of the trees and brush combined with the constant flow of the stream, as well as hints of a couple in the far upper-left corner, elude to the motif of life, still vibrant and growing within the landscape.";
	public static string Cat4AppPainting11MuseumName = "Art Gallery of South Australia";
	public static string Cat4AppPainting11MuseumLocation = "Adelaide, Australia";
	public static string Cat4AppPainting11ARPieceName1 = "Waterfall";
	public static string Cat4AppPainting11ARPieceDescription1 = "xxxxxxxx";
	public static string Cat4AppPainting11ARPieceName2 = "Dead Tree";
	public static string Cat4AppPainting11ARPieceDescription2 = "xxxxxxxx";
	public static string Cat4AppPainting11ARPieceName3 = "Ruins";
	public static string Cat4AppPainting11ARPieceDescription3 = "xxxxxxxx";
	public static string Cat4AppPainting11ARPieceName4 = "Clouds";
	public static string Cat4AppPainting11ARPieceDescription4 = "xxxxxxxx";

	// Individual Painting Information - Cat4AppPainting12
	public static string Cat4AppPainting12Name = "Landscape with the Fall of Icarus";
	public static string Cat4AppPainting12Artist = "Pieter Bruegel the Elder";
	public static string Cat4AppPainting12GalleryName = "Art of the Netherlands";
	public static int Cat4AppPainting12GalleryNumber = 4;
	public static string Cat4AppPainting12Movement = "Renaissance";
	public static string Cat4AppPainting12Origintation = "Antwerp, Belgium";
	public static string Cat4AppPainting12Nationality = "Dutch";
	public static string Cat4AppPainting12Date = "1555";
	public static string Cat4AppPainting12MainDescription = "As one of the most well-known Netherlandish Renaissance artists, Pieter Bruegel the Elder, also known as the 'Peasant Bruegel', was known for his landscape and genre painting scenes. For the time period, Bruegel was innovative in his selection of his scenes; he painting no portraits in his career and also painted few religious works, both of which were prominent within Renaissance art. Paintings like The Procession to Calvary, Netherlandish Proverbs, and The Hunters in the Snow were works that depicted depth, allegories of everyday life in the Netherlands, and proverbial scenes with deeper meanings and messages that were relevant to the Dutch society of the 16th Century. In Greek mythology, Icarus had a pair of wings created by his father, Daedalus. Not heeding the warnings from his father, Icarus flew too close to the sun, resulting in the wings being burned. Icarus then plummeted from the sky into the sea. This narrative is depicted by Pieter Bruegel the Elder in his Landscape with the Fall of Icarus. Within this painting, Bruegel paints what seems to be a quiet, peaceful, serene landscape of the coast of the Netherlands. However, upon closer inspection in the bottom-right corner of the canvas, Icarus' legs can be seen the moment he fell from the sky into the sea. This small but significant incorporation adds to the illusion that not all artwork appears as it seems; this peaceful landscape painting has a dark, sad story in the fall of Icarus.";
	public static string Cat4AppPainting12MuseumName = "Royal Museum of Fine Arts of Belgium";
	public static string Cat4AppPainting12MuseumLocation = "Brussels, Belgium";
	public static string Cat4AppPainting12ARPieceName1 = "Plow";
	public static string Cat4AppPainting12ARPieceDescription1 = "xxxxxxxx";
	public static string Cat4AppPainting12ARPieceName2 = "Ship";
	public static string Cat4AppPainting12ARPieceDescription2 = "xxxxxxxx";
	public static string Cat4AppPainting12ARPieceName3 = "Rocks";
	public static string Cat4AppPainting12ARPieceDescription3 = "xxxxxxxx";
	public static string Cat4AppPainting12ARPieceName4 = "Sunset";
	public static string Cat4AppPainting12ARPieceDescription4 = "xxxxxxxx";

	// Individual Painting Information - Cat4AppPainting13
	public static string Cat4AppPainting13Name = "Landscape with Windmills Near Haarlem";
	public static string Cat4AppPainting13Artist = "Jacob van Ruisdael";
	public static string Cat4AppPainting13GalleryName = "Art of the Netherlands";
	public static int Cat4AppPainting13GalleryNumber = 4;
	public static string Cat4AppPainting13Movement = "Golden Age";
	public static string Cat4AppPainting13Origintation = "Haarlem, Netherlands";
	public static string Cat4AppPainting13Nationality = "Dutch";
	public static string Cat4AppPainting13Date = "1652";
	public static string Cat4AppPainting13MainDescription = "As one of the prominent landscape painters of the Dutch Golden Age, Jacob van Ruisdael gave the art world an almost-hyper realistic aesthetic of painting. Van Ruisdael's paintings typically depicted atmosphere as the upper two-thirds of the canvas, which expressed motion, movement, and vivacity within his pieces. The extreme precision and detail within the clouds, land, and objects give the sense of a photographic appeal to viewers, making them feel as if a part of the scene. These include The Jewish Cemetery, Windmill at Wijk bij Duurstede, and A Wooded Marsh. Known for his detailed and meteorologically-rendered atmospheres, Jacob van Ruisdael was a master of portraying emotion and tone within his paintings due to the narrative skies. In his Landscape with Windmills Near Haarlem, van Ruisdael depicts iconic structures of the Netherlands landscape: windmills. Windmills are synonymous with being conductors of the wind and sky, and van Ruisdael makes it a point to create the same vivid detail and narrative within his atmospheres as he does within his windmills. Centuries later, British painter John Constable, who is also known for his vivid and lifelike atmospheres, actually replicated this exact painting within his ​Landscape with Windmills Near Haarlem.";
	public static string Cat4AppPainting13MuseumName = "Dulwich Picture Gallery";
	public static string Cat4AppPainting13MuseumLocation = "London, United Kingdom";
	public static string Cat4AppPainting13ARPieceName1 = "Windmills";
	public static string Cat4AppPainting13ARPieceDescription1 = "xxxxxxxx";
	public static string Cat4AppPainting13ARPieceName2 = "Clouds";
	public static string Cat4AppPainting13ARPieceDescription2 = "xxxxxxxx";
	public static string Cat4AppPainting13ARPieceName3 = "House";
	public static string Cat4AppPainting13ARPieceDescription3 = "xxxxxxxx";
	public static string Cat4AppPainting13ARPieceName4 = "Stream";
	public static string Cat4AppPainting13ARPieceDescription4 = "xxxxxxxx";

	// Individual Painting Information - Cat4AppPainting14
	public static string Cat4AppPainting14Name = "Night Café, The";
	public static string Cat4AppPainting14Artist = "Vincent van Gogh";
	public static string Cat4AppPainting14GalleryName = "Art of the Netherlands";
	public static int Cat4AppPainting14GalleryNumber = 4;
	public static string Cat4AppPainting14Movement = "Post-Impressionism";
	public static string Cat4AppPainting14Origintation = "Arles, France";
	public static string Cat4AppPainting14Nationality = "Dutch";
	public static string Cat4AppPainting14Date = "1888";
	public static string Cat4AppPainting14MainDescription = "Vincent van Gogh was one of the most influential historical figures of Western art. Most of his artwork came in the last several years of his life, and included portraits, self-portraits, landscapes, and still-life paintings. His artworks were very expressive with the bright palette and the loose, painterly brushstrokes. Over 2,000 of his works of art became the influential and inspirational cornerstone for modern works of art, including his Still Life: Vase with Fourteen Sunflowers, The Night Café, and his Starry Night​. The Night Café is a depiction of the Café de la Gare, a small café within Arles, France. Painted by Vincent van Gogh in 1888, The Night Café highlights the night life of cities and its citizens within France during the 19th Century. There are five figures depicted within the scene, most of which have been drinking due to their body positions as well as the bottles around the room. The overhead lights are comparable to the stars within van Gogh's iconic Starry Night. In letters to his brother, Theo, Vincent wrote that he wanted to render the foul, terrible passions of humans, in this case, alcohol and sex, through the harsh hues of red, yellow, and orange.";
	public static string Cat4AppPainting14MuseumName = "Yale University Art Gallery";
	public static string Cat4AppPainting14MuseumLocation = "New Haven, Connecticut, United States of America";
	public static string Cat4AppPainting14ARPieceName1 = "Lights";
	public static string Cat4AppPainting14ARPieceDescription1 = "xxxxxxxx";
	public static string Cat4AppPainting14ARPieceName2 = "Tables";
	public static string Cat4AppPainting14ARPieceDescription2 = "xxxxxxxx";
	public static string Cat4AppPainting14ARPieceName3 = "Pool Table";
	public static string Cat4AppPainting14ARPieceDescription3 = "xxxxxxxx";
	public static string Cat4AppPainting14ARPieceName4 = "Clock";
	public static string Cat4AppPainting14ARPieceDescription4 = "xxxxxxxx";

	// Individual Painting Information - Cat4AppPainting15
	public static string Cat4AppPainting15Name = "Starry Night";
	public static string Cat4AppPainting15Artist = "Vincent van Gogh";
	public static string Cat4AppPainting15GalleryName = "Art of the Netherlands";
	public static int Cat4AppPainting15GalleryNumber = 4;
	public static string Cat4AppPainting15Movement = "Post-Impressionism";
	public static string Cat4AppPainting15Origintation = "Arles, France";
	public static string Cat4AppPainting15Nationality = "Dutch";
	public static string Cat4AppPainting15Date = "1889";
	public static string Cat4AppPainting15MainDescription = "Vincent van Gogh was one of the most influential historical figures of Western art. Most of his artwork came in the last several years of his life, and included portraits, self-portraits, landscapes, and still-life paintings. His artworks were very expressive with the bright palette and the loose, painterly brushstrokes. Over 2,000 of his works of art became the influential and inspirational cornerstone for modern works of art, including his Still Life: Vase with Fourteen Sunflowers, The Night Café, and his Starry Night​. When someone mentions or thinks of Vincent van Gogh, the first painting to come to their mind is his Starry Night. As one of the most recognizable paintings in the world, Starry Night highlights a scene of calmness and peace during a time of great instability and sadness. Starry Night, comparable to van Gogh's Starry Night Over the Rhône, is the view of the night sky and cityscape of Saint-Rémy-de-Provence from the window of his room at the city's asylum. For a short time, van Gogh was able to find peace within a troubled time of his life, and that peace can be both seen and felt within his iconic Starry Night.";
	public static string Cat4AppPainting15MuseumName = "Museum of Modern Art";
	public static string Cat4AppPainting15MuseumLocation = "New York City, New York, United States of America";
	public static string Cat4AppPainting15ARPieceName1 = "Town";
	public static string Cat4AppPainting15ARPieceDescription1 = "xxxxxxxx";
	public static string Cat4AppPainting15ARPieceName2 = "Church";
	public static string Cat4AppPainting15ARPieceDescription2 = "xxxxxxxx";
	public static string Cat4AppPainting15ARPieceName3 = "Moon";
	public static string Cat4AppPainting15ARPieceDescription3 = "xxxxxxxx";
	public static string Cat4AppPainting15ARPieceName4 = "Stars";
	public static string Cat4AppPainting15ARPieceDescription4 = "xxxxxxxx";

	// Individual Painting Information - Cat4AppPainting16
	public static string Cat4AppPainting16Name = "Storm on the Sea of Galilee, The";
	public static string Cat4AppPainting16Artist = "Rembrandt van Rijn";
	public static string Cat4AppPainting16GalleryName = "Art of the Netherlands";
	public static int Cat4AppPainting16GalleryNumber = 4;
	public static string Cat4AppPainting16Movement = "Golden Age";
	public static string Cat4AppPainting16Origintation = "Amsterdam, Netherlands";
	public static string Cat4AppPainting16Nationality = "Dutch";
	public static string Cat4AppPainting16Date = "1633";
	public static string Cat4AppPainting16MainDescription = "Just like his Italian predecessors Michelangelo Buonarroti and Raphael Sanzio, Rembrandt van Rijn was better known by his first name: Rembrandt. This Dutch painter was considered one of the premier artists of Netherlandish history, excelling in replicating the history, drama, tension, and emotions within his portrait, genre scene, mythological, biblical, and landscape paintings. Known for his Impressionist-like brushstrokes, this Golden Age master brought alive the works of art, allowing viewers to be a part of each scene both physically and emotionally. A few of Rembrandt's most well-known paintings include The Night Watch, Bathsheba at her Bath, his Syndics of the Drapers' Guild, and The Anatomy Lesson of Dr Nicolaes Tulp​. As his only maritime painting, Rembrandt van Rijn's The Storm on the Sea of Galilee shows the torment and dangers of the open waters on the Sea of Galilee. A small sailboat is seen through the biblical narrative of the Gospel of Mark, which tells about the miraculous event of Jesus Christ calming the stormy sea and rough waters on the Sea of Galilee. This rendition by Rembrandt showcases the moments prior to that calming miracle, which can be visually foreshadowed by the white light illuminating the left side of the vessel, pushing away the darkness and the storm toward the right side of the canvas.";
	public static string Cat4AppPainting16MuseumName = "(Last Seen) Isabella Stewart-Gardner Museum";
	public static string Cat4AppPainting16MuseumLocation = "Boston, Massachusetts, United States of America";
	public static string Cat4AppPainting16ARPieceName1 = "Wave";
	public static string Cat4AppPainting16ARPieceDescription1 = "xxxxxxxx";
	public static string Cat4AppPainting16ARPieceName2 = "Ship";
	public static string Cat4AppPainting16ARPieceDescription2 = "xxxxxxxx";
	public static string Cat4AppPainting16ARPieceName3 = "Clouds";
	public static string Cat4AppPainting16ARPieceDescription3 = "xxxxxxxx";
	public static string Cat4AppPainting16ARPieceName4 = "Mast Line";
	public static string Cat4AppPainting16ARPieceDescription4 = "xxxxxxxx";

// ********************************************* GALLERY CAT 5 *********************************************
	// Main Gallery Information
	public static string AppGalleryName5 = "Art of the Rest of the World";
	public static string AppGalleryDescription5 = "Just as China and Japan dominated the East, Europe dominated the West in regards to art. From France to Spain, Russia, Scandinavia, and the rest of the continent, artists from antiquity to modernity have created and mastered art from a wide variety of movements and ages. These ages include the Baroque, Romanticism, Impressionism, and Post-Impressionism." + "\n" + "\n" + "After the Renaissance Age, Baroque art was encouraged and influenced by the Catholic Church and the Counter Reformation to bring citizens back to Catholicism from the simple and austere Protestantism. Baroque art tended to be highly decorative and extravagant, creating dramatic scenes and vivid narratives through its painting and sculpture." + "\n" + "\n" + "Originating in in Europe during the end of the 18th Century, Romantic art emphasized emotion and feeling of individuals as well as almost glorifying nature and history. Unlike the Baroque and Renaissance Ages where the focus was more Classical in nature, Romantic works of art focused more on the Medieval, adding a sense of heroism to paintings and sculptures." + "\n" + "\n" + "Impressionism was characterized by extremely loose brushstrokes that were visible throughout the entire painting. This 19th-Century art movement took landscapes, figures, and objects and incorporated both movement and emotion. Impressionism, in a matter of style, was almost the blending between Cubism and Baroque art; that dramatic and emotional appeal of the Baroque mixed with the inclusion of motion and the passing of time of Cubism." + "\n" + "\n" + "As a subset of Impressionism, Post-Impressionism (also spelled Postimpressionism) was mostly a French movement toward the end of the 19th Century. As a way to counter the Impressionist use of naturalism in their light and color, Post-Impressionist artists used a more abstract color palette, where the colors were more symbolic than natural." + "\n" + "\n" + "The artists in the Art of the Rest of the World Gallery include Ivan Aivazovsky, Gustave Caillebotte, Paul Cezanne, Eugene Delacroix, Theodore Gericault, Claude Monet, Edvard Munch, Henri Rousseau, Georges Seurat, and Diego Velazquez.";

	// Individual Painting Information - Cat5AppPainting01
	public static string Cat5AppPainting01Name = "Château Noir";
	public static string Cat5AppPainting01Artist = "Paul Cézanne";
	public static string Cat5AppPainting01GalleryName = "Art of the Rest of the World";
	public static int Cat5AppPainting01GalleryNumber = 5;
	public static string Cat5AppPainting01Movement = "Impressionism";
	public static string Cat5AppPainting01Origintation = "Provence, France";
	public static string Cat5AppPainting01Nationality = "French";
	public static string Cat5AppPainting01Date = "1903";
	public static string Cat5AppPainting01MainDescription = "Paul Cézanne led the art world through the turn of the 19th Century into the 20th Century. He used the painterly, expressive brushstrokes from the Impressionist style while incorporating his use of color to highlight specific figures, motifs, or symbolism within the scenes. Cézanne was influenced by geometric spacing within his compositions, allowing shapes and the formation of his figures and objects to form unique motifs in addition to his color palette. Some of his more impressive works of art include The Large Bathers, his Château Noir, and The Basket of Apples. Château Noir is a Post-Impressionist rendition of the lush hillside and Gothic ruins of the area Aix, France. Paul Cézanne depicts the run-down castle of Château Noir off in the distance behind trees and hills, adding to the allure of the scene. Viewers are able to see the large, rough brushstrokes of the artist, typical for the landscape paintings by Cézanne late in his career. These large brushstrokes add to the flow and rhythm of the landscape as it grows and covers the area surrounding the ruins. Cézanne depicts the château repeatedly over the course of the last few decades in his career, ultimately composing multiple variations of this lush, Gothic scene.";
	public static string Cat5AppPainting01MuseumName = "Museum of Modern Art";
	public static string Cat5AppPainting01MuseumLocation = "New York City, New York, United States of America";
	public static string Cat5AppPainting01ARPieceName1 = "Trees";
	public static string Cat5AppPainting01ARPieceDescription1 = "xxxxxxxx";
	public static string Cat5AppPainting01ARPieceName2 = "Sky";
	public static string Cat5AppPainting01ARPieceDescription2 = "xxxxxxxx";
	public static string Cat5AppPainting01ARPieceName3 = "House";
	public static string Cat5AppPainting01ARPieceDescription3 = "xxxxxxxx";

	// Individual Painting Information - Cat5AppPainting02
	public static string Cat5AppPainting02Name = "Dream, The";
	public static string Cat5AppPainting02Artist = "Henri Rousseau";
	public static string Cat5AppPainting02GalleryName = "Art of the Rest of the World";
	public static int Cat5AppPainting02GalleryNumber = 5;
	public static string Cat5AppPainting02Movement = "Post-Impressionism";
	public static string Cat5AppPainting02Origintation = "Paris, France";
	public static string Cat5AppPainting02Nationality = "French";
	public static string Cat5AppPainting02Date = "1910";
	public static string Cat5AppPainting02MainDescription = "Known around the art world as Le Douaniex, French for The Customs Officer, from his previous professions, Henri Rousseau was a late bloomer in his life for his painting career. As a self-taught artist who started painting full-time in his late 40s, Rousseau was renowned for his artistic ability and his precise technique. As an acclaimed primitive painter, his works showcase various scenes of nature and figures in their basic element, void of industry, architecture, or modern accessories, which can be seen within his Sleeping Gypsy and The Dream. As one of his last completed works of art, Henri Rousseau paints an almost surreal jungle scene within The Dream. Showing the natural landscape of the jungle, his Polish mistress can be seen lying nude on the left of the canvas. A wide variety of flora and fauna, ranging from a puma, to a snake, to various fruits, can be seen surrounding the young woman. The surreal nature of the scene is comparable to those by Salvador Dalí, giving the audience the euphoric experience of being in a dream.";
	public static string Cat5AppPainting02MuseumName = "Museum of Modern Art";
	public static string Cat5AppPainting02MuseumLocation = "New York City, New York, United States of America";
	public static string Cat5AppPainting02ARPieceName1 = "Oranges";
	public static string Cat5AppPainting02ARPieceDescription1 = "xxxxxxxx";
	public static string Cat5AppPainting02ARPieceName2 = "Flowers";
	public static string Cat5AppPainting02ARPieceDescription2 = "xxxxxxxx";
	public static string Cat5AppPainting02ARPieceName3 = "Lions";
	public static string Cat5AppPainting02ARPieceDescription3 = "xxxxxxxx";
	public static string Cat5AppPainting02ARPieceName4 = "Birds";
	public static string Cat5AppPainting02ARPieceDescription4 = "xxxxxxxx";

	// Individual Painting Information - Cat5AppPainting03
	public static string Cat5AppPainting03Name = "Fishing Boats in a Harbor";
	public static string Cat5AppPainting03Artist = "Ivan Aivazovsky";
	public static string Cat5AppPainting03GalleryName = "Art of the Rest of the World";
	public static int Cat5AppPainting03GalleryNumber = 5;
	public static string Cat5AppPainting03Movement = "Romanticism";
	public static string Cat5AppPainting03Origintation = "Kharkiv, Ukraine";
	public static string Cat5AppPainting03Nationality = "Russian";
	public static string Cat5AppPainting03Date = "1854";
	public static string Cat5AppPainting03MainDescription = "Ivan Konstantinovich Aivazovsky was a Russian Romantic painter, known for his mastery in maritime and marine art. Similar to that of J.M.W. Turner, Aivazovsky was eventually appointed painter of the Russian Navy, highlighting his realistic and emotionally-rendered paintings throughout the middle of the 19th Century. Of the 6,000 paintings composed over his lifetime, some of Aivazovsky's works include his View of Constantinople, Battle of Navarino, and his Tempest by Sounion, most of which are held in galleries in Russia or in private collections. Ivan Aivazovsky painted his Fishing Boats in a Harbor in 1854. Similar to the Romantic style of J.M.W. Turner and his maritime paintings, Aivazovsky portrays realistic and idyllic paintings of ships and maritime scenes that hold his own. Within his Fishing Boats in a Harbor, the artist renders a small rowboat float atop a calm water surface. Inside the boat are two figures and a fishing net full of fish caught from the harbor. A gull flies just above the surface of the water next to the boat as a large sailboat is seen within the foggy background. Viewers are placed right above the surface line of the water, as if they are placed within a nearby boat gazing upon the calm, morning scene.";
	public static string Cat5AppPainting03MuseumName = "Private Collection";
	public static string Cat5AppPainting03MuseumLocation = "Private Collection";
	public static string Cat5AppPainting03ARPieceName1 = "Small Boat";
	public static string Cat5AppPainting03ARPieceDescription1 = "xxxxxxxx";
	public static string Cat5AppPainting03ARPieceName2 = "Large Ship";
	public static string Cat5AppPainting03ARPieceDescription2 = "xxxxxxxx";
	public static string Cat5AppPainting03ARPieceName3 = "Fog";
	public static string Cat5AppPainting03ARPieceDescription3 = "xxxxxxxx";

	// Individual Painting Information - Cat5AppPainting04
	public static string Cat5AppPainting04Name = "Impression, Sunrise";
	public static string Cat5AppPainting04Artist = "Claude Monet";
	public static string Cat5AppPainting04GalleryName = "Art of the Rest of the World";
	public static int Cat5AppPainting04GalleryNumber = 5;
	public static string Cat5AppPainting04Movement = "Impressionism";
	public static string Cat5AppPainting04Origintation = "Argenteuil, France";
	public static string Cat5AppPainting04Nationality = "French";
	public static string Cat5AppPainting04Date = "1872";
	public static string Cat5AppPainting04MainDescription = "As a founder of French Impressionist painting, Claude Monet used the emotional, painterly brushstrokes to depict the beauty and serenity of the French landscape during the 19th and 20th Centuries. Monet's landscapes, including his Impression, Sunrise, Mouth of the Seine at Honfleur, and Flowers on the Riverbank at Argenteuil, highlight the movement of light and the passage of time over the landscapes - the passing of both days as well as seasons. Claude Monet's Impression, Sunrise was shown at the art show entitled 'Exhibition of the Impressionists' in Paris in 1874. This particular painting was the inspiration for the name of the Impressionist movement. Located in the same port city of Le Havre as his Fishing Boats Leaving the Harbor, Monet implements the same techniques to portray the various boats and water of the region. However, this particular painting contains less people and maritime vessels, which helps add to the calmness and serenity of the early-morning hour. The bright sun's reflection is captured within the large brushstrokes of the water, as each small ripple and wave is depicted by a single brushstroke.";
	public static string Cat5AppPainting04MuseumName = "Musée Marmottan Monet";
	public static string Cat5AppPainting04MuseumLocation = "Paris, France";
	public static string Cat5AppPainting04ARPieceName1 = "xxxxxxxx";
	public static string Cat5AppPainting04ARPieceDescription1 = "xxxxxxxx";
	public static string Cat5AppPainting04ARPieceName2 = "xxxxxxxx";
	public static string Cat5AppPainting04ARPieceDescription2 = "xxxxxxxx";
	public static string Cat5AppPainting04ARPieceName3 = "xxxxxxxx";
	public static string Cat5AppPainting04ARPieceDescription3 = "xxxxxxxx";
	public static string Cat5AppPainting04ARPieceName4 = "xxxxxxxx";
	public static string Cat5AppPainting04ARPieceDescription4 = "xxxxxxxx";
	public static string Cat5AppPainting04ARPieceName5 = "xxxxxxxx";
	public static string Cat5AppPainting04ARPieceDescription5 = "xxxxxxxx";

	// Individual Painting Information - Cat5AppPainting05
	public static string Cat5AppPainting05Name = "Las Meninas";
	public static string Cat5AppPainting05Artist = "Diego Velázquez";
	public static string Cat5AppPainting05GalleryName = "Art of the Rest of the World";
	public static int Cat5AppPainting05GalleryNumber = 5;
	public static string Cat5AppPainting05Movement = "Baroque";
	public static string Cat5AppPainting05Origintation = "Madrid, Spain";
	public static string Cat5AppPainting05Nationality = "Spanish";
	public static string Cat5AppPainting05Date = "1656";
	public static string Cat5AppPainting05MainDescription = "As the leading painter of King Philip IV's court, Spanish artist Diego Velázquez was the preeminent master of the Spanish Baroque Age. Replicating the style of Caravaggio with his extreme use of chiaroscuro, Velázquez was able to exhibit an abundance of drama and emotion within his paintings. Aside from his genre scenes, Velázquez depicted portraits and scenes of Spanish nobility, including his paintings of Philip IV in Brown and Silver, Portrait of Pablo de Valladolid, and his most famous work: Las Meninas. If Caravaggio was the master of dramatic, tenebrist paintings in Italy, Velázquez was his counterpart in Spain. As one of the most iconic paintings in Spanish Baroque art, Diego Velázquez's Las Meninas showcases the large room of Margaret Theresa, daughter of King Philip IV. She is surrounded by various maids and bodyguards. Velázquez portrays himself standing just behind a rather large canvas on the left side of the painting, as he and Margaret face out toward the viewer. However, they are most likely looking at King Philip IV and his second wife, Mariana of Austria. There is a small mirror on the back wall of the room, similar to that of Jan van Eyck's Arnolfini Portrait, which contains the reflection of the King and Queen of Spain. Viewers are meant to be a part of this occasion as if they are King Philip IV and Queen Mariana.";
	public static string Cat5AppPainting05MuseumName = "Museo Nacional del Prado";
	public static string Cat5AppPainting05MuseumLocation = "Madrid, Spain";
	public static string Cat5AppPainting05ARPieceName1 = "xxxxxxxx";
	public static string Cat5AppPainting05ARPieceDescription1 = "xxxxxxxx";
	public static string Cat5AppPainting05ARPieceName2 = "xxxxxxxx";
	public static string Cat5AppPainting05ARPieceDescription2 = "xxxxxxxx";
	public static string Cat5AppPainting05ARPieceName3 = "xxxxxxxx";
	public static string Cat5AppPainting05ARPieceDescription3 = "xxxxxxxx";
	public static string Cat5AppPainting05ARPieceName4 = "xxxxxxxx";
	public static string Cat5AppPainting05ARPieceDescription4 = "xxxxxxxx";
	public static string Cat5AppPainting05ARPieceName5 = "xxxxxxxx";
	public static string Cat5AppPainting05ARPieceDescription5 = "xxxxxxxx";

	// Individual Painting Information - Cat5AppPainting06
	public static string Cat5AppPainting06Name = "Liberty Leading the People";
	public static string Cat5AppPainting06Artist = "Eugène Delacroix";
	public static string Cat5AppPainting06GalleryName = "Art of the Rest of the World";
	public static int Cat5AppPainting06GalleryNumber = 5;
	public static string Cat5AppPainting06Movement = "Romanticism";
	public static string Cat5AppPainting06Origintation = "Paris, France";
	public static string Cat5AppPainting06Nationality = "French";
	public static string Cat5AppPainting06Date = "1830";
	public static string Cat5AppPainting06MainDescription = "Along with friend Théodore Géricault, Eugène Delacroix was a French-born Romantic painter who depicted scenes or allegories of the culture of France during the early 19th Century. These Romantic paintings were vibrant in both color and in emotion, containing an abundance of drama and fluidity that would feed viewers. Paintings like Delacroix's Death of Sardanapalus, Massacre at Chois, and his most famous Liberty Leading the People all captivated the minds and hearts of viewers within France, from the noble families to the common classes of French society. Eugène Delacroix's most iconic painting, Liberty Leading the People, is a visual metaphor for the July Revolution in France. Also known as the French Revolution, the July Revolution of 1830 occurred due to the complete maltreatment of King Charles X upon the people of France. The citizens led a revolt that overthrew the King and gave way for his cousin, Louis Philippe, in order to start progressing from rule by ancestry to rule by popular sovereignty. The central woman in Delacroix's painting is the metaphorical representation of the country and citizens of France, as she carries the flag as a way to highlight the nationalism and pride exuded by the French in order to execute this revolution. The painting is, to this day, still a symbol for the nation of France, and is one of the iconic centerpieces within the Louvre Museum.";
	public static string Cat5AppPainting06MuseumName = "Louvre Museum";
	public static string Cat5AppPainting06MuseumLocation = "Paris, France";
	public static string Cat5AppPainting06ARPieceName1 = "xxxxxxxx";
	public static string Cat5AppPainting06ARPieceDescription1 = "xxxxxxxx";
	public static string Cat5AppPainting06ARPieceName2 = "xxxxxxxx";
	public static string Cat5AppPainting06ARPieceDescription2 = "xxxxxxxx";
	public static string Cat5AppPainting06ARPieceName3 = "xxxxxxxx";
	public static string Cat5AppPainting06ARPieceDescription3 = "xxxxxxxx";
	public static string Cat5AppPainting06ARPieceName4 = "xxxxxxxx";
	public static string Cat5AppPainting06ARPieceDescription4 = "xxxxxxxx";
	public static string Cat5AppPainting06ARPieceName5 = "xxxxxxxx";
	public static string Cat5AppPainting06ARPieceDescription5 = "xxxxxxxx";

	// Individual Painting Information - Cat5AppPainting07
	public static string Cat5AppPainting07Name = "Paris Street, Rainy Day";
	public static string Cat5AppPainting07Artist = "Gustave Caillebotte";
	public static string Cat5AppPainting07GalleryName = "Art of the Rest of the World";
	public static int Cat5AppPainting07GalleryNumber = 5;
	public static string Cat5AppPainting07Movement = "Impressionism";
	public static string Cat5AppPainting07Origintation = "Paris, France";
	public static string Cat5AppPainting07Nationality = "French";
	public static string Cat5AppPainting07Date = "1877";
	public static string Cat5AppPainting07MainDescription = "Although an artist himself, Gustave Caillebotte was also a patron of Impressionist art. Born in Paris, France, in 1848, Caillebotte painted a little more realistically than other Impressionist artists, such as Claude Monet or Edgar Degas. This might have been due to his interest in the early stages of photography; the realistic influence from photography mixed with his patronage of Impressionist art blended together to form his own, unique style, which can be seen within works such as his Portrait de l'artiste, Paris Street, Rainy Day, and his Yellow Roses in a Vase. Seen as one of his most famous paintings, Gustave Caillebotte's Paris Street, Rainy Day depicts several French citizens walking through the city streets across from the Gare Saint-Lazare rail station - possibly an homage to Claude Monet's Gare Saint Lazare. The umbrellas along with the muted-grey sky highlight the rainy sensation felt throughout the entire scene. This also differs from the vibrancy of most other Impressionist works of art, especially the lushness of Monet's floral paintings.";
	public static string Cat5AppPainting07MuseumName = "Art Institute of Chicago";
	public static string Cat5AppPainting07MuseumLocation = "Chicago, Illinois, United States of America";
	public static string Cat5AppPainting07ARPieceName1 = "xxxxxxxx";
	public static string Cat5AppPainting07ARPieceDescription1 = "xxxxxxxx";
	public static string Cat5AppPainting07ARPieceName2 = "xxxxxxxx";
	public static string Cat5AppPainting07ARPieceDescription2 = "xxxxxxxx";
	public static string Cat5AppPainting07ARPieceName3 = "xxxxxxxx";
	public static string Cat5AppPainting07ARPieceDescription3 = "xxxxxxxx";
	public static string Cat5AppPainting07ARPieceName4 = "xxxxxxxx";
	public static string Cat5AppPainting07ARPieceDescription4 = "xxxxxxxx";
	public static string Cat5AppPainting07ARPieceName5 = "xxxxxxxx";
	public static string Cat5AppPainting07ARPieceDescription5 = "xxxxxxxx";

	// Individual Painting Information - Cat5AppPainting08
	public static string Cat5AppPainting08Name = "Raft of the Medusa, The";
	public static string Cat5AppPainting08Artist = "Théodore Géricault";
	public static string Cat5AppPainting08GalleryName = "Art of the Rest of the World";
	public static int Cat5AppPainting08GalleryNumber = 5;
	public static string Cat5AppPainting08Movement = "Romanticism";
	public static string Cat5AppPainting08Origintation = "Paris, France";
	public static string Cat5AppPainting08Nationality = "French";
	public static string Cat5AppPainting08Date = "1818";
	public static string Cat5AppPainting08MainDescription = "Alongside Eugène Delacroix, Théodore Géricault was a pioneer of the French Romantic Age of art. Born in Rouen, Géricault started his career by replicating the styles and techniques of Peter Paul Rubens, Titian, and Diego Velázquez. Géricault's interest in military scenes was apparent within his emotion-filled paintings, heightening the drama of the moment and narrative. This can be visually seen within paintings such as The Raft of the Medusa, The Charging Chasseur, and his Heroic Landscape with Fishermen​ As an iconic staple of French Romantic art, Théodore Géricault's The Raft of the Medusa shows a crowded, wooden raft in the aftermath of the wreck of the Medusa, a French boat that crashed off the coast of Mauritania in 1816. Only 15 souls survived of the almost 150 that originally boarded the vessel. Géricault depicts the chaos, terror, and torment of the scene, adding to the Romantic aesthetic while also telling the horrifying story of the aftermath of the wreck, which led to murder, cannibalism, and terror of the survivors. The 16-foot-high by 23-foot-wide painting is massive in scale, allowing viewers to fully become immersed in the terror and grandeur of the scene.";
	public static string Cat5AppPainting08MuseumName = "Louvre Museum";
	public static string Cat5AppPainting08MuseumLocation = "Paris, France";
	public static string Cat5AppPainting08ARPieceName1 = "xxxxxxxx";
	public static string Cat5AppPainting08ARPieceDescription1 = "xxxxxxxx";
	public static string Cat5AppPainting08ARPieceName2 = "xxxxxxxx";
	public static string Cat5AppPainting08ARPieceDescription2 = "xxxxxxxx";
	public static string Cat5AppPainting08ARPieceName3 = "xxxxxxxx";
	public static string Cat5AppPainting08ARPieceDescription3 = "xxxxxxxx";
	public static string Cat5AppPainting08ARPieceName4 = "xxxxxxxx";
	public static string Cat5AppPainting08ARPieceDescription4 = "xxxxxxxx";
	public static string Cat5AppPainting08ARPieceName5 = "xxxxxxxx";
	public static string Cat5AppPainting08ARPieceDescription5 = "xxxxxxxx";

	// Individual Painting Information - Cat5AppPainting09
	public static string Cat5AppPainting09Name = "Scream, The";
	public static string Cat5AppPainting09Artist = "Edvard Munch";
	public static string Cat5AppPainting09GalleryName = "Art of the Rest of the World";
	public static int Cat5AppPainting09GalleryNumber = 5;
	public static string Cat5AppPainting09Movement = "Expressionism";
	public static string Cat5AppPainting09Origintation = "Berlin, Germany";
	public static string Cat5AppPainting09Nationality = "Norwegian";
	public static string Cat5AppPainting09Date = "1893";
	public static string Cat5AppPainting09MainDescription = "Born in the Kingdom of Norway, Edvard Munch was an Expressionist artist who dealt with an illness, grief, and the constant worry and anxiety of inheriting a family mental disorder, all at a young age. These feelings and emotions led to Munch's unique, psychological style of art known as 'soul painting'. His most famous painting, and one of the most famous works of art in the world, The Scream was conceived after Munch hearing the disembodied screams of nature after a walk when the sky turned blood red. Also known as The Scream of Nature, Edvard Munch's The Scream has become an iconic painting synonymous with terror, anxiety, and the horrors of humanity. The blood-red sky with the bridge over a fjord helps to drive the emotional intensity of the painting. The expression of Munch's painting has become used throughout references within popular culture, including the memorable scream by the young Kevin McAllister in Home Alone as well as the iconic mask of Ghostface from the thriller, Scream.";
	public static string Cat5AppPainting09MuseumName = "National Gallery";
	public static string Cat5AppPainting09MuseumLocation = "Oslo, Norway";
	public static string Cat5AppPainting09ARPieceName1 = "xxxxxxxx";
	public static string Cat5AppPainting09ARPieceDescription1 = "xxxxxxxx";
	public static string Cat5AppPainting09ARPieceName2 = "xxxxxxxx";
	public static string Cat5AppPainting09ARPieceDescription2 = "xxxxxxxx";
	public static string Cat5AppPainting09ARPieceName3 = "xxxxxxxx";
	public static string Cat5AppPainting09ARPieceDescription3 = "xxxxxxxx";
	public static string Cat5AppPainting09ARPieceName4 = "xxxxxxxx";
	public static string Cat5AppPainting09ARPieceDescription4 = "xxxxxxxx";
	public static string Cat5AppPainting09ARPieceName5 = "xxxxxxxx";
	public static string Cat5AppPainting09ARPieceDescription5 = "xxxxxxxx";

	// Individual Painting Information - Cat5AppPainting10
	public static string Cat5AppPainting10Name = "Sunday Afternoon on the Island of La Grande Jatte";
	public static string Cat5AppPainting10Artist = "Georges Seurat";
	public static string Cat5AppPainting10GalleryName = "Art of the Rest of the World";
	public static int Cat5AppPainting10GalleryNumber = 5;
	public static string Cat5AppPainting10Movement = "Impressionism";
	public static string Cat5AppPainting10Origintation = "Paris, France";
	public static string Cat5AppPainting10Nationality = "French";
	public static string Cat5AppPainting10Date = "1885";
	public static string Cat5AppPainting10MainDescription = "Georges-Pierre Seurat was a Post-Impressionist painter born in Paris in 1859. He is known for the implementation of two unique techniques: chromoluminarism and pointillism. Chromoluminarism, also called divisionism, is where colors are separated by blocks or dots within the painting as opposed to blending the colors. Pointillism is the creation of small dots of paint to create textures, figures, and objects. These unique implementations can be viewed within Seurat's ​Sunday Afternoon on the Island of La Grande Jatte, Young Woman Powdering Herself, and The Circus. Best known for its presence within the comedy Ferris Bueller's Day Off, Georges Seurat's ​Sunday Afternoon on the Island of La Grande Jatte is the leading example of art and art history that implements pointillism. Seurat uses small dots, comparable to the modern-day pixel on computer screens and in photography, of paint and color to create textures, figures, and objects. Within Ferris Bueller's Day Off, viewers can actually see the pointillism at work each time they zoom into the painting. The overall scene highlights a festive, family-filled day where citizens of Paris are relaxing and lounging on the Île de la Grande Jatte, a small island set within the River Seine.";
	public static string Cat5AppPainting10MuseumName = "Art Institute of Chicago";
	public static string Cat5AppPainting10MuseumLocation = "Chicago, Illinois, United States of America";
	public static string Cat5AppPainting10ARPieceName1 = "xxxxxxxx";
	public static string Cat5AppPainting10ARPieceDescription1 = "xxxxxxxx";
	public static string Cat5AppPainting10ARPieceName2 = "xxxxxxxx";
	public static string Cat5AppPainting10ARPieceDescription2 = "xxxxxxxx";
	public static string Cat5AppPainting10ARPieceName3 = "xxxxxxxx";
	public static string Cat5AppPainting10ARPieceDescription3 = "xxxxxxxx";
	public static string Cat5AppPainting10ARPieceName4 = "xxxxxxxx";
	public static string Cat5AppPainting10ARPieceDescription4 = "xxxxxxxx";
	public static string Cat5AppPainting10ARPieceName5 = "xxxxxxxx";
	public static string Cat5AppPainting10ARPieceDescription5 = "xxxxxxxx";

	// Individual Painting Information - Cat5AppPainting11
	public static string Cat5AppPainting11Name = "Water Lilies";
	public static string Cat5AppPainting11Artist = "Claude Monet";
	public static string Cat5AppPainting11GalleryName = "Art of the Rest of the World";
	public static int Cat5AppPainting11GalleryNumber = 5;
	public static string Cat5AppPainting11Movement = "Impressionism";
	public static string Cat5AppPainting11Origintation = "Giverny, France";
	public static string Cat5AppPainting11Nationality = "French";
	public static string Cat5AppPainting11Date = "1922";
	public static string Cat5AppPainting11MainDescription = "As a founder of French Impressionist painting, Claude Monet used the emotional, painterly brushstrokes to depict the beauty and serenity of the French landscape during the 19th and 20th Centuries. Monet's landscapes, including his Impression, Sunrise, Mouth of the Seine at Honfleur, and Flowers on the Riverbank at Argenteuil, highlight the movement of light and the passage of time over the landscapes - the passing of both days as well as seasons. Claude Monet's Water Lilies is a series of over 250 paintings of various representations and styles of the garden of lilies that were growing at his home in Germany. Beginning in 1889, Monet's series of water lilies spanned the remainder of his life, painting the iconic flower up until his death in 1926. Various paintings are housed around the world, including the Musée de l'Orangerie, the Museum of Modern Art, and this particular version, housed in the Toledo Museum of Art. Monet's ability to capture the peacefulness, calmness, and idyllic nature of the water lilies are seen in each of his 250 versions.";
	public static string Cat5AppPainting11MuseumName = "Toledo Museum of Art";
	public static string Cat5AppPainting11MuseumLocation = "Toledo, Ohio, United States of America";
	public static string Cat5AppPainting11ARPieceName1 = "xxxxxxxx";
	public static string Cat5AppPainting11ARPieceDescription1 = "xxxxxxxx";
	public static string Cat5AppPainting11ARPieceName2 = "xxxxxxxx";
	public static string Cat5AppPainting11ARPieceDescription2 = "xxxxxxxx";
	public static string Cat5AppPainting11ARPieceName3 = "xxxxxxxx";
	public static string Cat5AppPainting11ARPieceDescription3 = "xxxxxxxx";
	public static string Cat5AppPainting11ARPieceName4 = "xxxxxxxx";
	public static string Cat5AppPainting11ARPieceDescription4 = "xxxxxxxx";
	public static string Cat5AppPainting11ARPieceName5 = "xxxxxxxx";
	public static string Cat5AppPainting11ARPieceDescription5 = "xxxxxxxx";

	// Individual Painting Information - Cat5AppPainting12
	public static string Cat5AppPainting12Name = "When Will You Marry?";
	public static string Cat5AppPainting12Artist = "Paul Gauguin";
	public static string Cat5AppPainting12GalleryName = "Art of the Rest of the World";
	public static int Cat5AppPainting12GalleryNumber = 5;
	public static string Cat5AppPainting12Movement = "Post-Impressionism";
	public static string Cat5AppPainting12Origintation = "Tahiti, French Polynesia";
	public static string Cat5AppPainting12Nationality = "French";
	public static string Cat5AppPainting12Date = "1892";
	public static string Cat5AppPainting12MainDescription = "Born Eugène Henri Paul Gauguin in Paris, France, this masterful Post-Impressionist painter was known for his synthetic style of blending colors and forms, almost as a middle ground between the style of Vincent van Gogh and Henri Rousseau. Known for his portrait works, especially of citizens of the Caribbean, Central America, and Tahiti, Gauguin brought to life the various cultures of the rest of the world to Western art. These vibrant cultures and peoples can be seen within his Where Do We Come From? What Are We? Where Are We Going?, Woman with a Flower, and his Riders on the Beach. Sold in an auction as one of the highest bids for a single work of art - $210 million in 2015, Paul Gauguin's When Will You Marry is a mother-daughter portrait from his time spent in Tahiti. Similar to Henri Rousseau's primitive style of painting, Gauguin showcases the natural tones within his color palette throughout the entire piece. Audiences can feel the parental guidance from the mother's expression, and even annoyance from the daughter, as the two are seen discussing the questions of life and growth.";
	public static string Cat5AppPainting12MuseumName = "Private Collection";
	public static string Cat5AppPainting12MuseumLocation = "Private Collection";
	public static string Cat5AppPainting12ARPieceName1 = "xxxxxxxx";
	public static string Cat5AppPainting12ARPieceDescription1 = "xxxxxxxx";
	public static string Cat5AppPainting12ARPieceName2 = "xxxxxxxx";
	public static string Cat5AppPainting12ARPieceDescription2 = "xxxxxxxx";
	public static string Cat5AppPainting12ARPieceName3 = "xxxxxxxx";
	public static string Cat5AppPainting12ARPieceDescription3 = "xxxxxxxx";
	public static string Cat5AppPainting12ARPieceName4 = "xxxxxxxx";
	public static string Cat5AppPainting12ARPieceDescription4 = "xxxxxxxx";
	public static string Cat5AppPainting12ARPieceName5 = "xxxxxxxx";
	public static string Cat5AppPainting12ARPieceDescription5 = "xxxxxxxx";

	// Individual Painting Information - Cat5AppPainting13
	public static string Cat5AppPainting13Name = "Young Man at His Window";
	public static string Cat5AppPainting13Artist = "Gustave Caillebotte";
	public static string Cat5AppPainting13GalleryName = "Art of the Rest of the World";
	public static int Cat5AppPainting13GalleryNumber = 5;
	public static string Cat5AppPainting13Movement = "Impressionism";
	public static string Cat5AppPainting13Origintation = "Paris, France";
	public static string Cat5AppPainting13Nationality = "French";
	public static string Cat5AppPainting13Date = "1875";
	public static string Cat5AppPainting13MainDescription = "Although an artist himself, Gustave Caillebotte was also a patron of Impressionist art. Born in Paris, France, in 1848, Caillebotte painted a little more realistically than other Impressionist artists, such as Claude Monet or Edgar Degas. This might have been due to his interest in the early stages of photography; the realistic influence from photography mixed with his patronage of Impressionist art blended together to form his own, unique style, which can be seen within works such as his Portrait de l'artiste, Paris Street, Rainy Day, and his Yellow Roses in a Vase. Gustave Caillebotte employs his interest and influence of the realism of photography within his Young Man at His Window. The young man in question is his brother, René, in his home in Paris, France. The audience's eyes get pulled back through the scene through the winding streets as they carve their way through buildings. Caillebotte gives the illusion that the audience is also seeing what his brother is seeing as he stares off down the city streets.";
	public static string Cat5AppPainting13MuseumName = "Private Collection";
	public static string Cat5AppPainting13MuseumLocation = "Private Collection";
	public static string Cat5AppPainting13ARPieceName1 = "xxxxxxxx";
	public static string Cat5AppPainting13ARPieceDescription1 = "xxxxxxxx";
	public static string Cat5AppPainting13ARPieceName2 = "xxxxxxxx";
	public static string Cat5AppPainting13ARPieceDescription2 = "xxxxxxxx";
	public static string Cat5AppPainting13ARPieceName3 = "xxxxxxxx";
	public static string Cat5AppPainting13ARPieceDescription3 = "xxxxxxxx";
	public static string Cat5AppPainting13ARPieceName4 = "xxxxxxxx";
	public static string Cat5AppPainting13ARPieceDescription4 = "xxxxxxxx";
	public static string Cat5AppPainting13ARPieceName5 = "xxxxxxxx";
	public static string Cat5AppPainting13ARPieceDescription5 = "xxxxxxxx";
	
// --------------- FIREBASE VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
    
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}