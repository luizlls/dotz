using UnityEngine;

[System.Serializable]
class CustomColor
{
    public string Name { get; set; }

    public Color Background {
        get => new Color(bg.r / 255f, bg.g / 255f, bg.b / 255f);
    }

    public Color Foreground {
        get => new Color(fg.r / 255f, fg.g / 255f, fg.b / 255f);
    }

    public (int r, int g, int b) bg;
    public (int r, int g, int b) fg;
}

static class Colors
{
    public static CustomColor[] colors = new[] {

        new CustomColor {
            Name = "Color 1",
            bg = (220, 240, 246),
            fg = (44, 120, 233)
        },

        new CustomColor {
            Name = "Color 2",
            bg = (202, 33, 62),
            fg = (119, 10, 52)
        },

        new CustomColor {
            Name = "Color 3",
            bg = (24, 4, 40),
            fg = (224, 203, 192)
        },

        new CustomColor {
            Name = "Color 4",
            bg = (24, 4, 40),
            fg = (56, 76, 105)
        },

        new CustomColor {
            Name = "Color 5",
            bg = (237, 167, 5),
            fg = (185, 28, 100)
        },

        new CustomColor {
            Name = "Color 6",
            bg = (185, 28, 100),
            fg = (237, 167, 5)
        },

        new CustomColor {
            Name = "Color 7",
            bg = (246, 199, 174),
            fg = (11, 88, 101)
        },

        new CustomColor {
            Name = "Color 8",
            bg = (24, 4, 40),
            fg = (237, 164, 5)
        },

        new CustomColor {
            Name = "Color 9",
            bg = (124, 225, 255),
            fg = (9, 143, 148)
        },

        new CustomColor {
            Name = "Color 10",
            bg = (230, 179, 147),
            fg = (79, 46, 28)
        },

        new CustomColor {
            Name = "Color 11",
            bg = (245, 54, 95),
            fg = (63, 52, 71)
        },

        new CustomColor {
            Name = "Color 12",
            bg = (237, 164, 5),
            fg = (48, 98, 48)
        },

        new CustomColor {
            Name = "Color 13",
            bg = (245, 54, 95),
            fg = (119, 10, 52)
        },

        new CustomColor {
            Name = "Color 14",
            bg = (196, 229, 220),
            fg = (92, 46, 33)
        },

        new CustomColor {
            Name = "Color 15",
            bg = (252, 245, 220),
            fg = (235, 137, 0)
        },

        new CustomColor {
            Name = "Color 16",
            bg = (145, 202, 79),
            fg = (130, 54, 143)
        },

        new CustomColor {
            Name = "Color 17",
            bg = (79, 79, 79),
            fg = (184, 171, 171)
        },

        new CustomColor {
            Name = "Color 18",
            bg = (233, 214, 182),
            fg = (59, 141, 189)
        },

        new CustomColor {
            Name = "Color 19",
            bg = (105, 102, 101),
            fg = (10, 8, 7)
        },

        new CustomColor {
            Name = "Color 20",
            bg = (233, 129, 9),
            fg = (101, 58, 48)
        },

        new CustomColor {
            Name = "Color 21",
            bg = (233, 129, 9),
            fg = (189, 51, 13)
        },

        new CustomColor {
            Name = "Color 22",
            bg = (139, 166, 96),
            fg = (42, 127, 98)
        },

        new CustomColor {
            Name = "Color 23",
            bg = (240, 185, 103),
            fg = (65, 60, 88)
        },

        new CustomColor {
            Name = "Color 24",
            bg = (165, 125, 157),
            fg = (11, 29, 81)
        },

        new CustomColor {
            Name = "Color 25",
            bg = (247, 211, 195),
            fg = (245, 140, 108)
        },

        new CustomColor {
            Name = "Color 26",
            bg = (150, 51, 101),
            fg = (79, 15, 72)
        },

        new CustomColor {
            Name = "Color 27",
            bg = (101, 41, 17),
            fg = (171, 101, 41)
        },

        new CustomColor {
            Name = "Color 28",
            bg = (242, 221, 187),
            fg = (151, 84, 185)
        },

        new CustomColor {
            Name = "Color 29",
            bg = (223, 221, 234),
            fg = (184, 154, 163)
        },

        new CustomColor {
            Name = "Color 30",
            bg = (192, 255, 202),
            fg = (67, 95, 182)
        },

        new CustomColor {
            Name = "Color 31",
            bg = (83, 112, 17),
            fg = (6, 33, 54)
        },

        new CustomColor {
            Name = "Color 32",
            bg = (236, 183, 156),
            fg = (98, 71, 90)
        },

        new CustomColor {
            Name = "Color 33",
            bg = (229, 194, 145),
            fg = (27, 161, 152)
        },

        new CustomColor {
            Name = "Color 34",
            bg = (205, 65, 86),
            fg = (249, 243, 217)
        },

        new CustomColor {
            Name = "Color 35",
            bg = (240, 237, 204),
            fg = (58, 146, 156)
        },

        new CustomColor {
            Name = "Color 36",
            bg = (45, 71, 112),
            fg = (11, 9, 59)
        },

        new CustomColor {
            Name = "Color 38",
            bg = (224, 224, 215),
            fg = (64, 64, 69)
        },

        new CustomColor {
            Name = "Color 39",
            bg = (24, 4, 40),
            fg = (233, 129, 9)
        },

        new CustomColor {
            Name = "Color 40",
            bg = (240, 151, 67),
            fg = (39, 61, 94)
        },

        new CustomColor {
            Name = "Color 41",
            bg = (114, 10, 10),
            fg = (235, 137, 0)
        },

        new CustomColor {
            Name = "Color 42",
            bg = (15, 8, 14),
            fg = (71, 29, 43)
        },

        new CustomColor {
            Name = "Color 43",
            bg = (125, 4, 18),
            fg = (31, 5, 20)
        },

        new CustomColor {
            Name = "Color 44",
            bg = (156, 211, 170),
            fg = (45, 106, 142)
        },

        new CustomColor {
            Name = "Color 45",
            bg = (240, 159, 60),
            fg = (5, 112, 179)
        },

        new CustomColor {
            Name = "Color 46",
            bg = (54, 111, 245),
            fg = (81, 6, 150)
        },

        new CustomColor {
            Name = "Color 47",
            bg = (163, 219, 125),
            fg = (44, 37, 82)
        },

        new CustomColor {
            Name = "Color 48",
            bg = (237, 160, 149),
            fg = (50, 46, 87)
        },

        new CustomColor {
            Name = "Color 49",
            bg = (247, 206, 174),
            fg = (116, 44, 82)
        },

        new CustomColor {
            Name = "Color 50",
            bg = (242, 208, 141),
            fg = (237, 116, 59)
        },

        new CustomColor {
            Name = "Color 51",
            bg = (222, 11, 116),
            fg = (14, 8, 15)
        },

        new CustomColor {
            Name = "Color 52",
            bg = (255, 167, 241),
            fg = (250, 55, 175)
        }
    };
}