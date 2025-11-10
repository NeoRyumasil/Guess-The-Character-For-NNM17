using UnityEngine;

// Asset Menu untuk membuat instance dari ImageData di Unity Editor
[CreateAssetMenu(fileName = "ImageData", menuName = "Game Data/Image Data", order = 1)] 

public class ImageData : ScriptableObject
{

    // Kelas untuk menyimpan pasangan nama gambar dan sprite
    [System.Serializable]
    public class ImageEntry
    {
        public string _imageName;             // Nama gambar
        public Sprite _imageSpriteBlack;      // Sprite gambar penghitaman
        public Sprite _imageSpriteWhite;      // Sprite gambar pemutihan
    }
    // Array dari gambar
    public ImageEntry[] _images;
}
