# Matryoshka-style Grid-based Inventory and FPS Controller
 Matryoshka-style Grid-based Inventory System built using C# in Unity.
 This project also includes a basic FPS controller utilizing IK and a procedural recoil system for animation.

## Features:

A **matryoshka-style** system allows an inventory to be stacked inside of another inventory. 
(ex. a backpack inside of a backpack inside of a backpack)

A **grid-based** system allows different sized items to take up multiple slots.
(ex. Diablo, Escape From Tarkov, System Shock 2)

![Grid](https://lh3.googleusercontent.com/ugyKiLEfQWnk-jV1TX4kKJfsaHI8A0493s7H-irikoweGm9B-4CRpRoZgm69_DaJUrwIEQDkm6oykZ9ArzltggXq3jiG1MdVYKq1X3ynUhyNCxKfCxN9MzfIv1raSJAu6cVRcZCJNf8XvDA8kuJgnPLg7c4kKtk-bUaWY6Xtz52S-v1LdDXokQPrRcEfZBofTeiXXVhlp80Wp-6UxMMjB089q6M-9X9xfOCK4khAHlPxbIy-kzNzyN0KtoDrxCNyE9yeXzLT_n03AKSL7jz44UsoUz-9VWIsdkzvvrInXGnWlDMLVLOXiGRwqo9qQeDtbxEzbKHFdzrXQU4WbhjUwcIqlfS9NwwIMubgPEymaiZdLtu9qytOFXbNtZkusg4tnmE-V22jrSB91Ddb3LiRA3BDvNlB-zvCtGkngozB3zW40_oNJvX-Lp-XYxIe0RznrXeIUktPa6WhG5r5zuEgcY9ayY-PvG53k6zVj1pnSykm68eW31QZFuL6UutgKgMvyCTRmPHKkCBr1_78mhYrHO_AmCc1viXAPS7aWh4fIqpeu2yaORNS-3nu_YchZnNIfhdWdZBL9eh1rp4OZCwjVbKqjJkL9X8eLFYe3ezG0OMOn7Cca3td9bwkSyV6nZweknOoBkiouVDHJiygEgc7fyAv-jT_JuQZ7XwZpX_dZO6T4ArxyFTK8iIVdLfNNw--NctFNtXwY4nUTOGuC2mbPEBPfrJsaoCWKjnTbq3gQ0wi3eVukaC043_HIgHgFkmd1WibPhaxKFc9NIZL7fZg2Lu82U6hrIQJmJJUvx5A_UOgKOiw9WE0KRDV4NDD9ExS6OKwlo5LRNUAf_kdC_OngWi5WDD_jDNCG2JsegMjI74m1ScAAv7NjauyhvEahDKBt2DJP3Emw4Et9TMgW5VQlY0GNbkz9HtMn9UV2PEG-iBkCgX7fwWIpysSh9uf4-_lzb8_g25I9UKnll0WnryhSA=w268-h319-no?authuser=0)

Items labeled as weapons can be **equipped** using the **primary** or **secondary slot**.

![Primary and secondary slots](https://lh3.googleusercontent.com/t56xUQ8lbWR2UYYxbc5VhIqWxnX_qpIb59WQT9YZB1pQ4ec0sGbsDRLhwlphzKZXB7QJb8QtRyProrPNEq8VxQzf9Vc7p1d30Uq6uCqxwup93Pv_H2QfVpfoWTFoaIHStbCRRTdTkes-4Xa6pe2R25G3x9j99DsEXFkXU3v-8Tsnj_4AEAqs53axTtQdDikldOpOLI81NmFcgkZiX_GEALUZ9rlutWA92P5vvH_0sz3wO4D3ZTFu-FuRPDuDN_-t45LE5epQKdkw-RjsJYoPZIv_PxI0mJ8NfYxIX7442lPUEZrUUDQ4s69Sag4i6-GV2Rq-AmS_VDY3fmRU7qtW6_Zb5tIqqwfgvKhpGIKueG_HFD0uxJMtq3HD6vKuebuWjU5mFv1ggX8FlkpC9ymt69hH1Af6yqriErXQyNa5ppKodiGsHjDqOrXKk165jEnLENczGbvxDuNcIpHUNZCE1RIZfSmtA4pgm58QosQ6ZDpw1I2hE8m0h8gNSw7dU_QSmYmsmOxZ-djJ3Ek2Cv6Ak-DxP8j35huRDo9nBhTX8xN3fDrYugi6MMwiJAOy4zMrc_Do1FIeiMe3TnsL9KDKBGk8nAtzUjIzjr3C46g0UzQ9u7GxpyP5oWbV_y-OPLIv6JPL7t1thCgcOUO9nRL2Ybg1ga5sOvhvtX-nGlzywjVIuO-T7RI78LmSxt8N1EdtGRvbF7XuPfiT97uLQCJD6UczNbnPQWGnQK8RV3YO68Wb3wjqamMZObSXLeFsf9sEAZDSOUHnOkuiaRwOoFyKLmwyt05s0jskR3-We6LpO8yTlisNW3yAgc_LWQQqeRyX2SdcvU2Vdk99MHgqOfz-0b_Nt6y5LvPUaYGwz4Mkp515nuKlvlQmqTNxw6Rdyk1ehCbdzywcVDpRkTdzkJHjxEgfjZ7x5IqP5gzuudGmqzNijF2WIOd-iR1QQ29tyjdpB5PWcLyLIr8C_5GTaDgrQQ=w181-h126-no?authuser=0)

A **context menu** provides the user a quicker alternative for doing certain actions such as quickly moving the item to an equip slot with **Equip** or dropping the item with **Drop**.

![Context Menu](https://lh3.googleusercontent.com/lLD1dQdJQljg_s0hy_sh2ATiUC32dLrUXsvUISAYtScUrlfLf81VhQMK7Dh0kUYzObL0ONQeOKtt5wVlja9F7HnYsl80Y5zNKwfLueLZVjuPnvkbcxhI-yUzaDaFffKe3LF50ts2OlHh6GBLx7n2wF1DQaI2iwv7GjIbDNzEAeA6B6RvHKuVEK_4LNl3RkBXhXYnWFoKe3AgxyfjbXQEKony72BMpPwz9Rov9PqJpaqL14a0pQKYjW6w6_LtxIYbP7ZVGP7oxs9wOKB2yuRmFx8UUDMUw0eOi9HBJNQ2cZyTzyTrQlDp4oX0zXxifOwvjCmFWbaXTCIE6cUEa_AT65ifVk8pyV0gZFSmu77B1LaDk05fwDIma2Fc1w581LowfS6fw6DsuRBgYM2JymxynGfbgCl47omTW38x3WCtTkLhRRW0pPlZwxeO43CQ5sh4uCve0qU74Sp_8NKQ-14HAfDjnklCqLo6TbQ-ObmklRxrj_KS6NPbs54x4GSjIIjxwRgMZU0mdqks8tggLMJWcvN3bAp5DLEfMQzPe8k732JqbTqbLAX6FwkpB0kV1s0SJGnTX6JO8afSDTvDM_3IvKyO5Xf3staoA600ikJ5U6nNNeFCMxiv0aUctf3lfqNWYJPPFpySqL8eFX6wyMj8D_UDk3e0s4tGJZOf5pu5Gnji9_fVLa0gHeV8REPkkZYYs4PQqWviTwrjTLWsmK8_FC--xXW9aSHM_PLZbeHw6S4SA0N26RPVle4tPdV7jCA3B1C3oYwG0N1WLh5Ld7UcyTOcCEFN3Zv-nA6Ib_8szqz9ZJ5VWIjm4DycK705Foi1TXkWIJRjyzGO1Uo4AqkypLEHZE32A-LE6hFJUGklNSDnuHzSzpM6N66aPNTIofloUDjg1Ss-QPR-r3vu8IfRWMqbqM23yZpLM7wn4agd2AxJ77JFtQ6cCYD7ah8l_VOIpElvxZSjmDyeLvaUtrsKDg=w116-h99-no?authuser=0)

A **procedural recoil system** determines patterns for the weapon firing animations.

### - Controls -
**[F]** adds world objects to inventory.

**[TAB]** opens the inventory menu.

**[R]** rotates currently held inventory item's orientation.

**[Right Click]** opens the context menu.

**[1]** accesses the primary slot, **[2]** accesses the secondary slot.
