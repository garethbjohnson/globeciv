using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globe32 : Globe {
    public Globe32() {
        Tile tile0 = new Tile(0.000000014901161193847656, 3.1998870372772217, 0.000001043081283569336);
        tiles.Add(tile0);

        Tile tile1 = new Tile(-1.8474587202072144, 2.3850603103637695, 1.06662917137146);
        tiles.Add(tile1);
        tile1.neighbors.Add(tile0);

        Tile tile2 = new Tile(-1.726914882659912, 2.61027455329895, -0.9970362186431885);
        tiles.Add(tile2);
        tile2.neighbors.Add(tile1);
        tile2.neighbors.Add(tile0);

        Tile tile3 = new Tile(0.000000014901161193847656, 2.3850607872009277, -2.133260726928711);
        tiles.Add(tile3);
        tile3.neighbors.Add(tile2);
        tile3.neighbors.Add(tile0);

        Tile tile4 = new Tile(-1.8474587202072144, 1.066632866859436, -2.385059356689453);
        tiles.Add(tile4);
        tile4.neighbors.Add(tile2);
        tile4.neighbors.Add(tile3);

        Tile tile5 = new Tile(-1.141790747642517, -1.0666295289993286, -2.7924764156341553);
        tiles.Add(tile5);
        tile5.neighbors.Add(tile4);

        Tile tile6 = new Tile(1.141790747642517, -1.0666295289993286, -2.7924764156341553);
        tiles.Add(tile6);
        tile6.neighbors.Add(tile5);

        Tile tile7 = new Tile(0.0, 0.6162031888961792, -3.2264702320098877);
        tiles.Add(tile7);
        tile7.neighbors.Add(tile3);
        tile7.neighbors.Add(tile6);
        tile7.neighbors.Add(tile5);
        tile7.neighbors.Add(tile4);

        Tile tile8 = new Tile(1.847458839416504, 1.066632866859436, -2.385059356689453);
        tiles.Add(tile8);
        tile8.neighbors.Add(tile6);
        tile8.neighbors.Add(tile7);
        tile8.neighbors.Add(tile3);

        Tile tile9 = new Tile(2.989253282546997, 1.0666327476501465, -0.4074160158634186);
        tiles.Add(tile9);
        tile9.neighbors.Add(tile8);

        Tile tile10 = new Tile(1.726914882659912, 2.61027455329895, -0.9970362186431885);
        tiles.Add(tile10);
        tile10.neighbors.Add(tile3);
        tile10.neighbors.Add(tile0);
        tile10.neighbors.Add(tile9);
        tile10.neighbors.Add(tile8);

        Tile tile11 = new Tile(1.847458839416504, 2.3850603103637695, 1.06662917137146);
        tiles.Add(tile11);
        tile11.neighbors.Add(tile9);
        tile11.neighbors.Add(tile10);
        tile11.neighbors.Add(tile0);

        Tile tile12 = new Tile(0.000000014901161193847656, 2.610274314880371, 1.994069218635559);
        tiles.Add(tile12);
        tile12.neighbors.Add(tile11);
        tile12.neighbors.Add(tile0);
        tile12.neighbors.Add(tile1);

        Tile tile13 = new Tile(-1.141790747642517, 1.0666322708129883, 2.7924740314483643);
        tiles.Add(tile13);
        tile13.neighbors.Add(tile1);
        tile13.neighbors.Add(tile12);

        Tile tile14 = new Tile(-2.7942121028900146, 0.6162025928497314, 1.613236427307129);
        tiles.Add(tile14);
        tile14.neighbors.Add(tile13);
        tile14.neighbors.Add(tile1);

        Tile tile15 = new Tile(-2.989253282546997, 1.0666327476501465, -0.40741604566574097);
        tiles.Add(tile15);
        tile15.neighbors.Add(tile14);
        tile15.neighbors.Add(tile1);
        tile15.neighbors.Add(tile2);
        tile15.neighbors.Add(tile4);

        Tile tile16 = new Tile(-2.989253282546997, -1.0666296482086182, 0.4074176549911499);
        tiles.Add(tile16);
        tile16.neighbors.Add(tile14);
        tile16.neighbors.Add(tile15);

        Tile tile17 = new Tile(-1.8474586009979248, -2.385056972503662, -1.0666323900222778);
        tiles.Add(tile17);
        tile17.neighbors.Add(tile5);
        tile17.neighbors.Add(tile16);

        Tile tile18 = new Tile(0.0, -2.610271453857422, -1.994072675704956);
        tiles.Add(tile18);
        tile18.neighbors.Add(tile5);
        tile18.neighbors.Add(tile6);
        tile18.neighbors.Add(tile17);

        Tile tile19 = new Tile(1.847458839416504, -2.385056972503662, -1.0666323900222778);
        tiles.Add(tile19);
        tile19.neighbors.Add(tile18);
        tile19.neighbors.Add(tile6);

        Tile tile20 = new Tile(2.989253282546997, -1.0666296482086182, 0.4074176251888275);
        tiles.Add(tile20);
        tile20.neighbors.Add(tile19);
        tile20.neighbors.Add(tile9);

        Tile tile21 = new Tile(1.8474586009979248, -1.0666300058364868, 2.3850581645965576);
        tiles.Add(tile21);
        tile21.neighbors.Add(tile20);

        Tile tile22 = new Tile(1.141790747642517, 1.0666321516036987, 2.7924740314483643);
        tiles.Add(tile22);
        tile22.neighbors.Add(tile21);
        tile22.neighbors.Add(tile11);
        tile22.neighbors.Add(tile12);
        tile22.neighbors.Add(tile13);

        Tile tile23 = new Tile(2.7942121028900146, 0.6162025928497314, 1.613236427307129);
        tiles.Add(tile23);
        tile23.neighbors.Add(tile9);
        tile23.neighbors.Add(tile11);
        tile23.neighbors.Add(tile22);
        tile23.neighbors.Add(tile21);
        tile23.neighbors.Add(tile20);

        Tile tile24 = new Tile(0.000000014901161193847656, -0.6162023544311523, 3.226477861404419);
        tiles.Add(tile24);
        tile24.neighbors.Add(tile21);
        tile24.neighbors.Add(tile22);
        tile24.neighbors.Add(tile13);

        Tile tile25 = new Tile(-1.8474586009979248, -1.0666300058364868, 2.3850581645965576);
        tiles.Add(tile25);
        tile25.neighbors.Add(tile24);
        tile25.neighbors.Add(tile13);
        tile25.neighbors.Add(tile14);
        tile25.neighbors.Add(tile16);

        Tile tile26 = new Tile(-0.000000014901161193847656, -2.3850574493408203, 2.1332595348358154);
        tiles.Add(tile26);
        tile26.neighbors.Add(tile21);
        tile26.neighbors.Add(tile24);
        tile26.neighbors.Add(tile25);

        Tile tile27 = new Tile(-0.000000014901161193847656, -3.1998934745788574, 0.0);
        tiles.Add(tile27);
        tile27.neighbors.Add(tile19);
        tile27.neighbors.Add(tile26);
        tile27.neighbors.Add(tile17);
        tile27.neighbors.Add(tile18);

        Tile tile28 = new Tile(1.726914882659912, -2.6102712154388428, 0.9970344305038452);
        tiles.Add(tile28);
        tile28.neighbors.Add(tile21);
        tile28.neighbors.Add(tile26);
        tile28.neighbors.Add(tile27);
        tile28.neighbors.Add(tile19);
        tile28.neighbors.Add(tile20);

        Tile tile29 = new Tile(-1.726914882659912, -2.6102712154388428, 0.9970344305038452);
        tiles.Add(tile29);
        tile29.neighbors.Add(tile26);
        tile29.neighbors.Add(tile25);
        tile29.neighbors.Add(tile16);
        tile29.neighbors.Add(tile17);
        tile29.neighbors.Add(tile27);

        Tile tile30 = new Tile(2.7942121028900146, -0.6162014007568359, -1.613240122795105);
        tiles.Add(tile30);
        tile30.neighbors.Add(tile6);
        tile30.neighbors.Add(tile8);
        tile30.neighbors.Add(tile9);
        tile30.neighbors.Add(tile20);
        tile30.neighbors.Add(tile19);

        Tile tile31 = new Tile(-2.7942121028900146, -0.6162014007568359, -1.613240122795105);
        tiles.Add(tile31);
        tile31.neighbors.Add(tile4);
        tile31.neighbors.Add(tile5);
        tile31.neighbors.Add(tile17);
        tile31.neighbors.Add(tile16);
        tile31.neighbors.Add(tile15);
    }
}
