# **Console RSS Reader 📡**  

A **console-based RSS feed reader** built with **C#** that fetches and displays news from various categories like **World News, India News, .NET, Tech (Azure), Cricket, and more**.  

## **📌 How It Works**  

- The program displays a list of preset RSS feeds.  
- Select a category by entering the corresponding number.
- Each news article includes **a title, a link, and a description**.  
- Press **Enter** to return to the menu and select another feed.  

## **📂 Preset RSS Feeds**  

| Category               | Source |
|------------------------|-----------------------------------------------------|
| 🌍 World News         | [BBC World](https://feeds.bbci.co.uk/news/world/rss.xml) |
| 🇮🇳 India News       | [The Hindu - India](https://www.thehindu.com/news/national/feeder/default.rss) |
| 💻 .NET Development  | [Microsoft .NET Blog](https://devblogs.microsoft.com/dotnet/feed/) |
| ☁️ Azure Updates    | [Azure Blog](https://azure.microsoft.com/en-us/blog/feed/) |
| 🔴 Manchester United | [The Peoples Person](https://thepeoplesperson.com/feed/) |
| 🏏 Cricket News      | [ESPN Cricinfo](https://www.espncricinfo.com/rss/content/story/feeds/0.xml) |
| 📡 Live Cricket Scores | [Cricinfo Live Scores](https://static.cricinfo.com/rss/livescores.xml) |

- when you clone it, you can add new RSS feed's to the list as well

---

## **🛠 Prerequisites**  
- Install **.NET 9.0 SDK** → [Download Here](https://dotnet.microsoft.com/en-us/download)  

## **📥 Setup**  

1️⃣ Clone the repository:  
```bash
git clone https://github.com/slalithprasad/ConsoleRSSReader
cd ConsoleRSSReader
```

2️⃣ Install dependencies (if needed):  
```bash
dotnet restore
```

---

## **▶️ Running the RSS Reader**  
```bash
dotnet run
```

---

## **📜 Example Usage**  

```text
📡 Console RSS Reader

Select a category:

1. World - BBC
2. India - The Hindu
3. .NET - Microsoft Blog
4. Tech - Azure Updates
5. Manchester United
6. Cricket
7. Cricket Live Scores

Enter choice (1-7) or 'q' to quit: 7 

Enter the number of feeds that you want to read: 10

Fetching RSS feed from: Cricket Live Scores...

📰 Vidarbha 375/9 &  379/10 * v Kerala 342/10 
🔗 http://www.cricinfo.com/ci/engine/match/1445956.html?CMP=OTC-RSS 

Vidarbha 375/9 &  379/10 * v Kerala 342/10 

--------------------------------------------------
📰 Ace Capital Cricket Club 268/10  v Panadura Sports Club 111/2 &  249/10 *
🔗 http://www.cricinfo.com/ci/engine/match/1465857.html?CMP=OTC-RSS 

Ace Capital Cricket Club 268/10  v Panadura Sports Club 111/2 &  249/10 *

--------------------------------------------------
📰 Bloomfield Cricket and Athletic Club 365/3  v Badureliya Sports Club 87/10 &  231/10 *
🔗 http://www.cricinfo.com/ci/engine/match/1465859.html?CMP=OTC-RSS 

Bloomfield Cricket and Athletic Club 365/3  v Badureliya Sports Club 87/10 &  231/10 *

--------------------------------------------------
📰 Colts Cricket Club 274/10  v Chilaw Marians Cricket Club 210/10 &  229/7 *
🔗 http://www.cricinfo.com/ci/engine/match/1465858.html?CMP=OTC-RSS 

Colts Cricket Club 274/10  v Chilaw Marians Cricket Club 210/10 &  229/7 *

--------------------------------------------------
📰 Ragama Cricket Club 174/6 * v Negombo Cricket Club 246/8 
🔗 http://www.cricinfo.com/ci/engine/match/1465860.html?CMP=OTC-RSS 

Ragama Cricket Club 174/6 * v Negombo Cricket Club 246/8 

--------------------------------------------------
📰 Diasqua Little Sai Wan CC Women 82/10 * v Lantau Cricket Club Women 88/10 
🔗 http://www.cricinfo.com/ci/engine/match/1474247.html?CMP=OTC-RSS 

Diasqua Little Sai Wan CC Women 82/10 * v Lantau Cricket Club Women 88/10 

--------------------------------------------------
📰 Hong Kong Cricket Club Women 144  v Craigengower Cricket Club Women 115/8 *
🔗 http://www.cricinfo.com/ci/engine/match/1474248.html?CMP=OTC-RSS 

Hong Kong Cricket Club Women 144  v Craigengower Cricket Club Women 115/8 *

--------------------------------------------------
📰 United Services Recreation Club 143/8  v Diasqua Little Sai Wan Cricket Club 147/3 *
🔗 http://www.cricinfo.com/ci/engine/match/1474236.html?CMP=OTC-RSS 

United Services Recreation Club 143/8  v Diasqua Little Sai Wan Cricket Club 147/3 *

--------------------------------------------------
📰 Pakistan Association of Hong Kong 183/10 * v Hong Kong Cricket Club 228/7 
🔗 http://www.cricinfo.com/ci/engine/match/1474237.html?CMP=OTC-RSS 

Pakistan Association of Hong Kong 183/10 * v Hong Kong Cricket Club 228/7

--------------------------------------------------
📰 India 249/9  v New Zealand 35/1 *
🔗 http://www.cricinfo.com/ci/engine/match/1466425.html?CMP=OTC-RSS

India 249/9  v New Zealand 35/1 *

--------------------------------------------------

Press Enter to return to the menu...

📡 Console RSS Reader

Select a category:

1. World - BBC
2. India - The Hindu
3. .NET - Microsoft Blog
4. Tech - Azure Updates
5. Manchester United
6. Cricket
7. Cricket Live Scores

Enter choice (1-7) or 'q' to quit:  1

Enter the number of feeds that you want to read: 10

Fetching RSS feed from: World - BBC...

📰 Israel blocks entry of all humanitarian aid into Gaza
🔗 https://www.bbc.com/news/articles/c9q4w99je78o

Netanyahu is demanding Hamas agree to a US plan for a ceasefire extension, the Palestinian group says blocking aid is "cheap blackmail".

--------------------------------------------------
📰 Pro-Ukraine protests across US after Trump-Zelensky clash
🔗 https://www.bbc.com/news/articles/cdxqnxw6z73o

Hundreds of people gather in US cities to express their support for Ukraine after the Oval Office row.

--------------------------------------------------
📰 Most Republicans laud Trump after Zelensky showdown, but some express dismay
🔗 https://www.bbc.com/news/articles/cnvz566n523o
Fetching news from: World - BBC...

📰 Israel blocks entry of all humanitarian aid into Gaza
🔗 https://www.bbc.com/news/articles/c9q4w99je78o

Netanyahu is demanding Hamas agree to a US plan for a ceasefire extension, the Palestinian group says blocking aid is "cheap blackmail".

--------------------------------------------------
📰 Pro-Ukraine protests across US after Trump-Zelensky clash
🔗 https://www.bbc.com/news/articles/cdxqnxw6z73o

Hundreds of people gather in US cities to express their support for Ukraine after the Oval Office row.

--------------------------------------------------
Fetching news from: World - BBC...

📰 Israel blocks entry of all humanitarian aid into Gaza
🔗 https://www.bbc.com/news/articles/c9q4w99je78o

Netanyahu is demanding Hamas agree to a US plan for a ceasefire extension, the Palestinian group says blocking aid is "cheap blackmail".

--------------------------------------------------
📰 Pro-Ukraine protests across US after Trump-Zelensky clash
🔗 https://www.bbc.com/news/articles/cdxqnxw6z73o

Hundreds of people gather in US cities to express their support for Ukraine after the Oval Office row.

--------------------------------------------------
📰 Most Republicans laud Trump after Zelensky showdown, but some express dismay
🔗 https://www.bbc.com/news/articles/cnvz566n523o

The majority of Republicans say Zelensky was at fault for the spat, but one accused the president of "embracing Putin".

--------------------------------------------------
📰 Haiti police raid gang leader's stronghold in capital
🔗 https://www.bbc.com/news/articles/c78ejpvdlezo

Officials say several gang members have been killed in a major police operation in Port-au-Prince.

--------------------------------------------------
📰 Pope absent from St Peter's Square for third week
🔗 https://www.bbc.com/news/articles/c2kgqdkx9jxo

Pope Francis is unable to deliver his traditional Angelus prayer in person, with the Vatican publishing a text.

--------------------------------------------------
📰 Private spacecraft Blue Ghost lands on Moon
🔗 https://www.bbc.com/news/articles/cd9208qv1kzo

It was launched by Firefly Aerospace in January with the mission of exploring the Sea of Crises.

--------------------------------------------------
📰 How to watch the Oscars and who is nominated
🔗 https://www.bbc.com/news/articles/c93kq2kldrqo

Who will win, what can we expect and what has caused the most controversy this awards season?

--------------------------------------------------
📰 R&B hitmaker Angie Stone dead in car crash
🔗 https://www.bbc.com/news/articles/c1d4r2nk4yyo

The Wish I Didn't Miss You singer was involved in a collision in Alabama following a performance.

--------------------------------------------------
📰 Gene Hackman loved acting but 'hated everything that went with it'
🔗 https://www.bbc.com/news/articles/cvgwwyrnpzdo

Those who knew him discuss his brilliance, as well as his disdain for the trappings of Hollywood.

--------------------------------------------------
📰 Kurdish group PKK declares ceasefire with Turkey
🔗 https://www.bbc.com/news/articles/cgkmg3kmmero

The PKK calls for the release of its jailed leader Abdullah Ocalan to lead a process of disarmament.

--------------------------------------------------

Press Enter to return to the menu...
```

---

🚀 **Happy Reading!** 📡