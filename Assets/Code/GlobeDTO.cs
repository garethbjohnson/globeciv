using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GlobeDTO {
    public List<TileDTO> tiles = new List<TileDTO>();

    public List<Tile> getTiles() {
        List<Tile> deserializedTiles = new List<Tile>();

        for (int i = 0; i < tiles.Count; i++) {
            TileDTO tileDTO = tiles[i];
            Tile tile = tileDTO.getTile();

            for (int j = 0; j < tileDTO.neighbors.Count; j++) {
                int neighborIndex = tileDTO.neighbors[j];
                Tile neighbor = deserializedTiles[j];
                tile.neighbors.Add(neighbor);
            }

            deserializedTiles.Add(tile);
        }

        return deserializedTiles;
    }
}
