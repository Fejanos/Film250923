### 📋 Feladatok

## 1. Struktúra használata
- Hozz létre egy `Film nevű` struct-ot, amely tartalmazza:
- Cím (string)
- Rendező (string)
- Év (int)
- Hossz percben (int)

Példa:
```bash
struct Film
{
    public string Cim;
    public string Rendezo;
    public int Ev;
    public int Hossz;
}
```

---

## 2. Adatbekérés
Kérj be a felhasználótól 3 film adatot, és tárold őket egy tömbben (`Film[]`).

Példa:
```bash
Add meg az 1. film címét: Inception
Rendező: Christopher Nolan
Év: 2010
Hossz (percben): 148
```

---

## 3. Kiírás
Írd ki szépen formázva az összes film adatait a konzolra.

Példa:
```bash
Filmek listája:
Inception - Christopher Nolan, 2010, 148 perc
The Matrix - Wachowski, 1999, 136 perc
Interstellar - Christopher Nolan, 2014, 169 perc
```

---

## 4. Fájlkezelés
- Mentsd el a filmeket egy `filmek.txt` fájlba.
- Olvasd vissza a fájl tartalmát és jelenítsd meg a konzolban.

Példa fájl tartalom (`filmek.txt`):
```bash
Inception;Christopher Nolan;2010;148
The Matrix;Wachowski;1999;136
Interstellar;Christopher Nolan;2014;169
```

---

## 5. Szótár használata
Hozz létre egy `Dictionary<string, int>` szótárat, ahol:
- a kulcs a film címe,
- az érték a film hossza percben.

Példa:
```bash
filmSzotar["Inception"] = 148;
filmSzotar["The Matrix"] = 136;
filmSzotar["Interstellar"] = 169;
```

Kérj be egy címet a felhasználótól, és írd ki a hosszát, ha benne van a szótárban.

Példa konzol:
```bash
Írj be egy filmcímet: Interstellar
🎬 A film hossza: 169 perc
```

---

## 6. Extra kihívások
- Írd ki, melyik a leghosszabb film.
- Számold ki a filmek átlagos hosszát.
- Írd ki, hány film készült 2000 után.

Példa konzol:
```bash
A leghosszabb film: Interstellar (169 perc)
Átlagos hossz: 151 perc
2 film készült 2000 után
```
