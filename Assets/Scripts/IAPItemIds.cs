using UnityEngine;
public enum IAPItemIds
{
    // Fields
    UNKNOWN = 0
    ,IK_BGM_BUSTLING_MYSTERY = 1
    ,IK_BGM_CRYPTIC_PEARLS = 2
    ,IK_BGM_DARK_TIDE = 3
    ,IK_BGM_RESISTANCE_RATTLE = 4
    ,IK_BGM_ROYAL_CALAMITY = 5
    ,IK_BGM_SINISTER_TECHNOLOGY = 6
    ,IK_BGM_SOOTHING_STRUGGLE = 7
    ,IK_BACKGROUND_ARMY_BASE = 8
    ,IK_BACKGROUND_BROADWAY = 9
    ,IK_BACKGROUND_PALACE = 10
    ,IK_BACKGROUND_PARLIAMENT = 11
    ,IK_BACKGROUND_SECRET_BASE = 12
    ,IK_BACKGROUND_STADIUM = 13
    ,IK_CHARACTER_IKA_COMMANDO = 14
    ,IK_CHARACTER_IKA_LORII = 15
    ,IK_CHARACTER_IKA_PUNK = 16
    ,IK_CHARACTER_IKA_SCIENTST = 17
    ,IK_CHARACTER_IKA_SECRET_AGENT = 18
    ,IK_CHARACTER_IKA_WAITRESS = 19
    ,IK_CHARACTER_TAKO_CHEF = 20
    ,IK_CHARACTER_TAKO_GODFATHER = 21
    ,IK_CHARACTER_TAKO_NERD = 22
    ,IK_CHARACTER_TAKO_NINJA = 23
    ,IK_CHARACTER_TAKO_WRESTLER = 24
    ,IK_INFINITE_GAMEPLAY = 25
    ,IK_INSTANT_KILL_BUBBLE = 26
    ,IK_NO_ADS = 27
    ,IK_PVP_NO_ADS = 28
    ,IK_STARTER_BUNDLE = 29
    ,IK_CURRENCY_1500 = 30
    ,IK_CURRENCY_5000 = 31
    ,IK_CURRENCY_14000 = 32
    ,IK_CURRENCY_27000 = 33
    ,IK_CURRENCY_75000 = 34
    ,IK_CURRENCY_120000 = 35
    ,IK_SHELLS_10 = 36
    ,IK_SHELLS_25 = 37
    ,IK_SHELLS_40 = 38
    ,IK_SHELLS_80 = 39
    ,IK_BGM_SENSATIONAL_ENIGMA = 40
    ,IK_BGM_MISCHIEVOUS_WANDERER = 41
    ,IK_CHARACTER_TAKO_JAMIE = 42
    ,IK_CHARACTER_TAKO_WONG = 43
    ,IK_CHARACTER_IKA_GLLTY = 44
    ,IK_CHARACTER_IKA_SMUG = 45
    ,IK_CHARACTER_TAKO_MARN = 46
    ,IK_BGM_ROYAL_FACTOR = 47
    ,IK_BGM_LOST_IN_TRANSLATION = 48
    ,IK_BGM_BEATY_FIDDLER = 49
    ,IK_BGM_SERENE_TROLLING = 50
    ,IK_CHARACTER_MERMAID_BRANDEE = 51
    ,IK_CHARACTER_TAKO_HUNTO = 52
    ,IK_BGM_BREATH_TAKING_BEAUTY = 53
    ,IK_BGM_PROUD_HERITAGE = 54
    ,IK_CHARACTER_TAKO_NIXIA = 55
    ,IK_BGM_LIVELY_VIBE = 56
    ,IK_CHARACTER_IKA_LEAH = 57
    ,IK_BGM_ECCENTRIC_SPRITE = 58
    ,IK_CHARACTER_TAKO_SJ = 59
    ,IK_BGM_STRANGE_JUKEBOX = 60
    ,IK_CHARACTER_IKA_RYAN = 61
    ,IK_BGM_IKA_RYAN_THEME = 62
    ,IK_CHARACTER_TAKO_TRUMP = 63
    ,IK_BGM_TAKO_TRUMP_THEME = 64
    ,IK_BGM_IKA_LORII_THEME = 65
    ,IK_BGM_IKA_SMUG_THEME = 66
    ,IK_BGM_IKA_GLLTY_THEME = 67
    ,IK_BGM_IKA_LEAH_THEME = 68
    ,AVATAR_IKA_ARTIST_SPECIFIC_CUBE3D_A = 69
    ,AVATAR_IKA_ARTIST_SPECIFIC_SIGNATUREFLAG_B = 70
    ,AVATAR_IKA_BOXER_SPECIFIC_CUBE3D_A = 71
    ,AVATAR_IKA_BOXER_SPECIFIC_SIGNATUREFLAG_B = 72
    ,AVATAR_IKA_BUTCHER_SPECIFIC_CUBE3D_A = 73
    ,AVATAR_IKA_BUTCHER_SPECIFIC_SIGNATUREFLAG_B = 74
    ,AVATAR_IKA_COMMANDO_SPECIFIC_CUBE3D_A = 75
    ,AVATAR_IKA_COMMANDO_SPECIFIC_SIGNATUREFLAG_B = 76
    ,AVATAR_IKA_COWBOY_SPECIFIC_CUBE3D_A = 77
    ,AVATAR_IKA_COWBOY_SPECIFIC_SIGNATUREFLAG_B = 78
    ,AVATAR_IKA_HOBO_SPECIFIC_CUBE3D_A = 79
    ,AVATAR_IKA_HOBO_SPECIFIC_SIGNATUREFLAG_B = 80
    ,AVATAR_IKA_LORII_SPECIFIC_CUBE3D_A = 81
    ,AVATAR_IKA_LORII_SPECIFIC_SIGNATUREFLAG_B = 82
    ,AVATAR_IKA_PRINCESS_SPECIFIC_CUBE3D_A = 83
    ,AVATAR_IKA_PRINCESS_SPECIFIC_SIGNATUREFLAG_B = 84
    ,AVATAR_IKA_PUNK_SPECIFIC_CUBE3D_A = 85
    ,AVATAR_IKA_PUNK_SPECIFIC_SIGNATUREFLAG_B = 86
    ,AVATAR_IKA_SALESMAN_SPECIFIC_CUBE3D_A = 87
    ,AVATAR_IKA_SALESMAN_SPECIFIC_SIGNATUREFLAG_B = 88
    ,AVATAR_IKA_SCIENTIST_SPECIFIC_CUBE3D_A = 89
    ,AVATAR_IKA_SCIENTIST_SPECIFIC_SIGNATUREFLAG_B = 90
    ,AVATAR_IKA_SECRET_AGENT_SPECIFIC_CUBE3D_A = 91
    ,AVATAR_IKA_SECRET_AGENT_SPECIFIC_SIGNATUREFLAG_B = 92
    ,AVATAR_IKA_SENATOR_SPECIFIC_CUBE3D_A = 93
    ,AVATAR_IKA_SENATOR_SPECIFIC_SIGNATUREFLAG_B = 94
    ,AVATAR_IKA_WAITRESS_SPECIFIC_CUBE3D_A = 95
    ,AVATAR_IKA_WAITRESS_SPECIFIC_SIGNATUREFLAG_B = 96
    ,AVATAR_TAKO_BIKER_SPECIFIC_CUBE3D_A = 97
    ,AVATAR_TAKO_BIKER_SPECIFIC_SIGNATUREFLAG_B = 98
    ,AVATAR_TAKO_CHEF_SPECIFIC_CUBE3D_A = 99
    ,AVATAR_TAKO_CHEF_SPECIFIC_SIGNATUREFLAG_B = 100
    ,AVATAR_TAKO_CLOWN_SPECIFIC_CUBE3D_A = 101
    ,AVATAR_TAKO_CLOWN_SPECIFIC_SIGNATUREFLAG_B = 102
    ,AVATAR_TAKO_COP_SPECIFIC_CUBE3D_A = 103
    ,AVATAR_TAKO_COP_SPECIFIC_SIGNATUREFLAG_B = 104
    ,AVATAR_TAKO_GODFATHER_SPECIFIC_CUBE3D_A = 105
    ,AVATAR_TAKO_GODFATHER_SPECIFIC_SIGNATUREFLAG_B = 106
    ,AVATAR_TAKO_GYPSY_SPECIFIC_CUBE3D_A = 107
    ,AVATAR_TAKO_GYPSY_SPECIFIC_SIGNATUREFLAG_B = 108
    ,AVATAR_TAKO_HERO_SPECIFIC_CUBE3D_A = 109
    ,AVATAR_TAKO_HERO_SPECIFIC_SIGNATUREFLAG_B = 110
    ,AVATAR_TAKO_HIPPIE_SPECIFIC_CUBE3D_A = 111
    ,AVATAR_TAKO_HIPPIE_SPECIFIC_SIGNATUREFLAG_B = 112
    ,AVATAR_TAKO_KING_SPECIFIC_CUBE3D_A = 113
    ,AVATAR_TAKO_KING_SPECIFIC_SIGNATUREFLAG_B = 114
    ,AVATAR_TAKO_NERD_SPECIFIC_CUBE3D_A = 115
    ,AVATAR_TAKO_NERD_SPECIFIC_SIGNATUREFLAG_B = 116
    ,AVATAR_TAKO_NINJA_SPECIFIC_CUBE3D_A = 117
    ,AVATAR_TAKO_NINJA_SPECIFIC_SIGNATUREFLAG_B = 118
    ,AVATAR_TAKO_ROCKSTAR_SPECIFIC_CUBE3D_A = 119
    ,AVATAR_TAKO_ROCKSTAR_SPECIFIC_SIGNATUREFLAG_B = 120
    ,AVATAR_TAKO_WRESTLER_SPECIFIC_CUBE3D_A = 121
    ,AVATAR_TAKO_WRESTLER_SPECIFIC_SIGNATUREFLAG_B = 122
    ,AVATAR_SPECIAL_UFA_SPECIFIC_CUBE3D_A = 123
    ,AVATAR_SPECIAL_UFA_SPECIFIC_SIGNATUREFLAG_B = 124
    ,AVATAR_SPECIAL_SHIN_UFA_SPECIFIC_CUBE3D_A = 125
    ,AVATAR_SPECIAL_SHIN_UFA_SPECIFIC_SIGNATUREFLAG_B = 126
    ,AVATAR_TAKO_JAMIE_SPECIFIC_CUBE3D_A = 127
    ,AVATAR_TAKO_JAMIE_SPECIFIC_SIGNATUREFLAG_B = 128
    ,AVATAR_TAKO_WONG_SPECIFIC_CUBE3D_A = 129
    ,AVATAR_TAKO_WONG_SPECIFIC_SIGNATUREFLAG_B = 130
    ,AVATAR_IKA_GLLTY_SPECIFIC_CUBE3D_A = 131
    ,AVATAR_IKA_GLLTY_SPECIFIC_SIGNATUREFLAG_B = 132
    ,AVATAR_IKA_SMUG_SPECIFIC_CUBE3D_A = 133
    ,AVATAR_IKA_SMUG_SPECIFIC_SIGNATUREFLAG_B = 134
    ,AVATAR_TAKO_MARN_SPECIFIC_CUBE3D_A = 135
    ,AVATAR_TAKO_MARN_SPECIFIC_SIGNATUREFLAG_B = 136
    ,AVATAR_SPECIAL_MERMAID_BRANDEE_SPECIFIC_CUBE3D_A = 137
    ,AVATAR_SPECIAL_MERMAID_BRANDEE_SPECIFIC_SIGNATUREFLAG_B = 138
    ,AVATAR_TAKO_HUNTO_SPECIFIC_CUBE3D_A = 139
    ,AVATAR_TAKO_HUNTO_SPECIFIC_SIGNATUREFLAG_B = 140
    ,AVATAR_TAKO_NIXIA_SPECIFIC_CUBE3D_A = 141
    ,AVATAR_TAKO_NIXIA_SPECIFIC_SIGNATUREFLAG_B = 142
    ,AVATAR_IKA_LEAH_SPECIFIC_CUBE3D_A = 143
    ,AVATAR_IKA_LEAH_SPECIFIC_SIGNATUREFLAG_B = 144
    ,AVATAR_TAKO_SJ_SPECIFIC_CUBE3D_A = 145
    ,AVATAR_TAKO_SJ_SPECIFIC_SIGNATUREFLAG_B = 146
    ,AVATAR_IKA_RYAN_SPECIFIC_CUBE3D_A = 147
    ,AVATAR_IKA_RYAN_SPECIFIC_SIGNATUREFLAG_B = 148
    ,AVATAR_TAKO_TRUMP_SPECIFIC_CUBE3D_A = 149
    ,AVATAR_TAKO_TRUMP_SPECIFIC_SIGNATUREFLAG_B = 150
    ,IK_SHELL_PACK_20 = 151
    ,IK_SHELL_PACK_50 = 152
    ,IK_SHELL_PACK_150 = 153
    ,IK_SHELL_PACK_350 = 154
    ,IK_SHELL_PACK_700 = 155
    ,IK_SHELL_PACK_1600 = 156
    ,IK_CHARACTER_TAKO_BENNY = 157
    ,IK_BGM_TAKO_BENNY_THEME = 158
    ,VIP_1 = 159
    ,VIP_2 = 160
    ,VIP_3 = 161
    ,VIP_4 = 162
    ,VIP_1_TO_2 = 163
    ,VIP_1_TO_3 = 164
    ,VIP_1_TO_4 = 165
    ,VIP_2_TO_3 = 166
    ,VIP_2_TO_4 = 167
    ,VIP_3_TO_4 = 168
    ,IK_BGM_TAKO_WONG_THEME = 169
    ,IK_BGM_TAKO_HUNTO_THEME = 170
    ,IK_BGM_TAKO_NIXIA_THEME = 171
    ,IK_BGM_TAKO_VIN_THEME = 172
    ,IK_BGM_TAKO_MARN_THEME = 173
    ,IK_BGM_TAKO_JAMIE_THEME = 174
    ,IK_BGM_MARMAID_THEME = 175
    ,IK_CHARACTER_IRON_SHARK = 176
    

}
