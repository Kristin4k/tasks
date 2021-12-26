using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6._3
{
    class Program
    {
        // Белый ферзь и чёрный король
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белого ферзя");
            var whiteQueenPosition = Console.ReadLine();

            Console.WriteLine("Введите позицию черного короля");
            var blackKingPosition = Console.ReadLine();

            if (!IsFiguresPositionsCorrect(whiteQueenPosition, blackKingPosition))
            {
                Console.WriteLine("Позиции фигур не соответствуют условиям задачи");
                Console.ReadKey();

                return;
            }

            Console.WriteLine("Введите ход белого ферзя");
            var move = Console.ReadLine();

            if (IsQueenCanMakeSafeMove(whiteQueenPosition, blackKingPosition, move))
            {
                Console.WriteLine($"Ферзь {whiteQueenPosition} может безопастно пойти на клетку {move}");
            }
            else
            {
                Console.WriteLine($"Ферзь {whiteQueenPosition} не может  пойти на клетку {move}");

                Console.ReadKey();
            }
        }
        static bool IsFiguresPositionsCorrect(string queenPosition, string kingPosition)
        {
            return !IsEqualPositions(queenPosition, kingPosition) &&
                IsKingPositionCorrect(kingPosition) &&
                !IsQueenStrikesKing(queenPosition, kingPosition) &&
                !IsKingStrikesQueen(queenPosition, kingPosition);
        }

        static bool IsQueenCanMakeSafeMove(string queenPosition, string kingPosition, string move)
        {
            return IsQueenCanMove(queenPosition, move) &&
                !IsKingStrikesQueen(move, kingPosition);
        }

        static bool IsEqualPositions(string position1, string position2)
        {
            return position1 == position2;
        }

        static bool IsKingStrikesQueen(string queenPosition, string kingPosition)
        {
            int qx, qy, kx, ky;
            (qy, qx) = GetCoordinates(queenPosition);
            (ky, kx) = GetCoordinates(kingPosition);

            return Math.Abs(kx - qx) <= 1 && Math.Abs(ky - qy) <= 1;
        }

        static bool IsQueenStrikesKing(string queenPosition, string kingPosition)
        {
            return IsQueenCanMove(queenPosition, kingPosition);
        }

        static bool IsKingPositionCorrect(string kingPosition)
        {
            int kx, ky;
            (kx, ky) = GetCoordinates(kingPosition);

            return ky > 0 && ky < 7;
        }

        static bool IsQueenCanMove(string queenPosition, string move)
        {
            int qx, qy, mx, my;
            (qy, qx) = GetCoordinates(queenPosition);
            (my, mx) = GetCoordinates(move);

            return qy == my || qx == mx || Math.Abs(qy - my) == Math.Abs(qx - mx);
        }

        static (int, int) GetCoordinates(string position)
        {
            var row = (int)position[1] - 0x31;
            var column = (int)position[0] - 0x61;

            return (row, column);
        }
    }
}