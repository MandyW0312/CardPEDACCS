"P" Problem

- Have 20 cards shuffled and laid out in a horizontal line face down
- Place the cards into numerical order by doing the following:
  -- Turn over 2 cards at any time:
  --- if desired you can swap these 2 cards
  -- You may only refer to the cards based on their position in your list left to right, based on their index (starting at 0)
  -- You may not keep track of the value of any cards in any manner other than by turning over the 2 cards and considering their value

  "E" Examples

  - Card [0] is a 9, Card [1] is a 1 9 > 1 swap these cards
  - Card [11] is a 14, Card [12] is a 15 14 NOT > 15 leave these cards in their positions

  "D" Data Structure

  - Cards (class)
    -- Properties: Numbers on the Cards ( 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20)
    -- Behaviors: Turn over the card
    Swap the cards

  "A" Algorithm

  - 1. Create a list of 20 Cards ( 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20)
  - 2. Shuffle the Cards
  - 3. Lay out the Cards Horizontally Face Down
  - 4. Turn over the Card at Position [0] and the Card at Position [1]
       -- if Card at Position [0] > Card at Position [1], swap the Cards
       --- else leave them in their current Position
       ---- Turn those Cards back over Face Down
  - 5. Turn over the Card at Position [1] and the Card at Position [2]
       -- if Card at Position [1] > Card at Position [2], swap the Cards
       --- else leave them in their current Position
       ---- Turn those Cards back over Face Down
  - 6. Turn over the Card at Position [2] and the Card at Position [3]
       -- if Card at Position [2] > Card at Position [3], swap the Cards
       --- else leave them in their current Position
       ---- Turn those Cards back over Face Down
  - 7. Turn over the Card at Position [3] and the Card at Position [4]
       -- if Card at Position [3] > Card at Position [4], swap the Cards
       --- else leave them in their current Position
       ---- Turn those Cards back over Face Down
  - 8. Turn over the Card at Position [4] and the Card at Position [5]
       -- if Card at Position [4] > Card at Position [5], swap the Cards
       --- else leave them in their current Position
       ---- Turn those Cards back over Face Down
  - 9. Turn over the Card at Position [5] and the Card at Position [6]
       -- if Card at Position [5] > Card at Position [6], swap the Cards
       --- else leave them in their current Position
       ---- Turn those Cards back over Face Down
  - 10. Turn over the Card at Position [6] and the Card at Position [7]
        -- if Card at Position [6] > Card at Position [7], swap the Cards
        --- else leave them in their current Position
        ---- Turn those Cards back over Face Down
  - 11. Turn over the Card at Position [7] and the Card at Position [8]
        -- if Card at Position [7] > Card at Position [8], swap the Cards
        --- else leave them in their current Position
        ---- Turn those Cards back over Face Down
  - 12. Turn over the Card at Position [8] and the Card at Position [9]
        -- if Card at Position [8] > Card at Position [9], swap the Cards
        --- else leave them in their current Position
        ---- Turn those Cards back over Face Down
  - 13. Turn over the Card at Position [9] and the Card at Position [10]
        -- if Card at Position [9] > Card at Position [10], swap the Cards
        --- else leave them in their current Position
        ---- Turn those Cards back over Face Down
  - 14. Turn over the Card at Position [10] and the Card at Position [11]
        -- if Card at Position [10] > Card at Position [11], swap the Cards
        --- else leave them in their current Position
        ---- Turn those Cards back over Face Down
  - 15. Turn over the Card at Position [11] and the Card at Position [12]
        -- if Card at Position [11] > Card at Position [12], swap the Cards
        --- else leave them in their current Position
        ---- Turn those Cards back over Face Down
  - 16. Turn over the Card at Position [12] and the Card at Position [13]
        -- if Card at Position [12] > Card at Position [13], swap the Cards
        --- else leave them in their current Position
        ---- Turn those Cards back over Face Down
  - 17. Turn over the Card at Position [13] and the Card at Position [14]
        -- if Card at Position [13] > Card at Position [14], swap the Cards
        --- else leave them in their current Position
        ---- Turn those Cards back over Face Down
  - 18. Turn over the Card at Position [14] and the Card at Position [15]
        -- if Card at Position [14] > Card at Position [15], swap the Cards
        --- else leave them in their current Position
        ---- Turn those Cards back over Face Down
  - 19. Turn over the Card at Position [15] and the Card at Position [16]
        -- if Card at Position [15] > Card at Position [16], swap the Cards
        --- else leave them in their current Position
        ---- Turn those Cards back over Face Down
  - 20. Turn over the Card at Position [16] and the Card at Position [17]
        -- if Card at Position [16] > Card at Position [17], swap the Cards
        --- else leave them in their current Position
        ---- Turn those Cards back over Face Down
  - 21. Turn over the Card at Position [17] and the Card at Position [18]
        -- if Card at Position [17] > Card at Position [18], swap the Cards
        --- else leave them in their current Position
        ---- Turn those Cards back over Face Down
  - 22. Turn over the Card at Position [18] and the Card at Position [19]
        -- if Card at Position [18] > Card at Position [19], swap the Cards
        --- else leave them in their current Position
        ---- Turn those Cards back over Face Down
  - 23. Repeat Steps 4 through 23, until all of the Cards are in numerical order
