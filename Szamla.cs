namespace beadando_feladat
{
    internal class Szamla
    {   
        /// <summary>
        /// A számla tulajdonosa
        /// </summary>
        public string tulajdonos { get; set; }
       
        /// <summary>
        /// A számla egyenlege
        /// </summary>
        public int egyenleg { get; set; }

        /// <summary>
        /// A számlák egyenlegfeltöltéséhez használt függvény!
        /// </summary>
        /// <param name="osszeg">Az összeg, amivel a számla egyenlegét növelni kívánjukl!</param>
        /// <returns>A feltöltés utáni egyenleg!</returns>
        public string Feltoltes(int osszeg)
        {
            egyenleg = egyenleg + osszeg;
            return $"{egyenleg}";
        }

        /// <summary>
        /// Az egyik számláról való utalás a másik számlára!
        /// </summary>
        /// <param name="osszeg">Az átutalni kívánt összeg értéke!</param>
        /// <param name="masikSzamla">Az a számla amelyre utalni kívánunk!</param>
        /// 
        public void Utalas(int osszeg, Szamla masikSzamla)
        {
            egyenleg = egyenleg - osszeg;
            masikSzamla.egyenleg = masikSzamla.egyenleg + osszeg;
        }

        /// <summary>
        /// A számláról való pénzkivételhez használt függvény!
        /// </summary>
        /// <param name="osszeg">A kivenni kívántösszeg értéke!</param>
        /// <returns>A kivétel uténi számlaegyenleg!</returns>
        public string Kivetel(int osszeg)
        {
            egyenleg = egyenleg - osszeg;
            return $"{egyenleg}";
        }


        /// <summary>
        /// A tulajdonos váétására szolgáló függvény!
        /// </summary>
        /// <param name="ujTulaj">A kívánt új tulajdonos</param>
        /// <returns>Visszaadja az új tulajdonost!</returns>
        public string Tulajvaltas(string ujTulaj)
        {
            tulajdonos = ujTulaj;
            return $"{tulajdonos}";
        }
    }
}