using System;

namespace LoF___TAM_Alpha_3._1__b15_
{
    class Program
    {
        static void Main(string[] args)
        {
			//Альфа 3.1 (b15)
			//Альфа 3!
			 //Дата создания - 29.05.2021
			 //Отпуск - с 30.05.2021 по 11.08.2021
			 //Дата выхода - 00.00.2021	!

			int battleChoise,duelChoise, battle,difficulty, gamesAll = 0, gamesWin = 0;
			int kolvoplayer;
			int kolvoRound = 1;
			int playerRound=0;
			int JoeRound=0;
			int battlePercents, colour, kolvoRev, kolvoKnife;
			int playerKnife = 0;
			int enemyKnife = 0;
			int playerRev=0;
			int enemyRev = 0;
			int hurtChoise;
			Random knife1 = new Random();
			int knife = knife1.Next();
			Random rev1 = new Random();
			int rev = rev1.Next();
			Random rnd1JoeRev = new Random();
			Random rnd1JoeKnife = new Random();
			int rndJoeRev = rnd1JoeRev.Next();
			int rndJoeKnife = rnd1JoeKnife.Next();
			string name, name1, name2;
			int playerHP, BillHP,JoeHP;
			Random playerHit1 = new Random();
			Random playerKritHit1 = new Random();
			Random BillHit1 = new Random();
			Random JoeHit1 = new Random();
			int playerHit = playerHit1.Next();
			int playerKritHit = playerKritHit1.Next();
			int BillHit = BillHit1.Next();
			int JoeHit = JoeHit1.Next();
			Console.WriteLine("Выбери цвет фона и текста в игре:\n\n1. (По Умолчанию)\nФон - Чёрный;\nТекст - Белый;\n\n2. Фон - Чёрный;\nТекст - Красный;\n\n3. Фон - Белый;\nТекст - Чёрный;");
			colour = int.Parse(Console.ReadLine());
			while (colour < 1 || colour > 3)
            {
				Console.Clear();
				Console.WriteLine("Ошибка ввода! Повторите попытку!");
				Console.WriteLine("Выбери цвет фона и текста в игре:\n\n1. Фон - Чёрный;\nТекст - Белый;\n\n2. Фон - Чёрный;\nТекст - Красный;\n\n3. Фон - Белый;\nТекст - Чёрный;");
				colour = int.Parse(Console.ReadLine());
			}
			if(colour==1)
            {
				Console.BackgroundColor = ConsoleColor.Black;
				Console.ForegroundColor = ConsoleColor.White;
				Console.Clear();
            }
			else if(colour==2)
            {
				Console.BackgroundColor = ConsoleColor.Black;
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Clear();
			}
			else if(colour==3)
            {
				Console.BackgroundColor = ConsoleColor.White;
				Console.ForegroundColor = ConsoleColor.Black;
				Console.Clear();
			}
            Console.WriteLine("\t\t\t\t\tДорогие игроки!\nМоя игра продолжает довольно быстро развиваться. Однако работаю над ней пока что только я один.\nВ каждой альфе я стараюсь добавить как можно больше нового и интересного контента.\nЧто то я вырезаю, что то дополняю, что то добавляю и т.д. и т.п.\nТем самым я постепенно совершенствую её как я хочу и как вы хотите.\nЭто требует много времени, а ведь ещё перевод на английский.......\nЯ приношу извинения англоязычным фанатам моей игры, но с этой альфы до момента, когда мы с вами посчитаем нужным,\nанглийский язык в этой игре будет отсутствовать.\nПриношу свои извинения!\n\nP.s. Пишите мне на электронную почту!!!\nglebsmailbox@gmail.com\n\nМатюшев Глеб Игоревич - разработчик Лиги Сражений  : Древней Тайны\n\n\nНажмите 'Пробел', чтобы продолжить.\n");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\t\t\t\tLeague Of Fighting : The Ancient Mystery\tby GIM\nLoading...\nLoading...\nLoading...\n\n\n\n");
            Console.WriteLine("\t\t\t\tWelcome to League Of Fighting : The Ancient Mystery\tAlpha 3\n\n\n\n");
            Console.WriteLine("Hello, Player! What is yor name?/Привет, Игрок! Как тебя зовут?");
            name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hello, " + name.ToString());
            Console.WriteLine("\t\t\t\t\t\tВнимание!\nИгра становится всё больше и больше, поэтому для того, чтобы видель всю отображающуюся информация, пожалуйста, откройте окно игры в полном экране (F 11)!!!\n\n\n\nНажмите 'Пробел', чтобы продолжить\n");
            Console.ReadKey();
            do
			{
				Console.Clear();
				Console.WriteLine("Я думаю, что третья альфа моей игры получила ну оооочень много крутого контента!!! Но впередиии.............загадочный....................................................новый боец ДЖО!!!!!!!!!!!!!!!!!!\nDEV\n\n===================================================================================================================\n1 - Новая игра\n2 - Режим Дуэль;\n3 - Особенности этой альфы;\n4 - Список бойцов;\n5 - Статистика;\n6. История изменений игры;\n7. Список возможных изменений в следующих альфах;\n0 - Выход из игры;\nВаш выбор:\n");
				battleChoise = int.Parse(Console.ReadLine());
				switch (battleChoise)
				{
					case 1:
						{
							Console.Clear();
							Console.WriteLine("Выберите сложность!\n1 - Легко;\n2 - Средне;\n3 - Сложно;\n");
							difficulty = int.Parse(Console.ReadLine());
							while (difficulty < 1 || difficulty > 3)
							{
								Console.Clear();
								Console.WriteLine("Ошибка! Повторите!");
								Console.WriteLine("Выберите сложность!\n1 - Легко;\n2 - Средне;\n3 - Сложно;\n");
								difficulty = int.Parse(Console.ReadLine());

							}
							if (difficulty == 1)
							{
								playerHP = 110;
								BillHP = 100;
							}
							else if (difficulty == 2)
							{
								playerHP = 100;
								BillHP = 100;
							}
							else
							{
								playerHP = 100;
								BillHP = 110;
							}
							Console.Clear();
							Console.WriteLine("Прямо сейчас мы увидим поединок между двумя первоклассными бойцами\nСегодня сражаются:");
							Console.WriteLine("Билл против " + name.ToString());
							while (playerHP > 0 && BillHP > 0)
							{
								Console.WriteLine("Вы можете ударить врага рукой, нажав клавишу 1\nВы также можете ранить врага ударом ногой!!! (Для этого нажмите 2)\n");
								battle = int.Parse(Console.ReadLine());
								Console.Clear();
								while (battle < 1 || battle > 2)
								{
									Console.Clear();
									Console.WriteLine("НЕПРАВИЛЬНО!!!!!");
									Console.WriteLine("Вы можете ударить врага рукой, нажав клавишу 1\nВы также можете ранить врага ударом ногой!!! (Для этого нажмите 2)");
									battle = int.Parse(Console.ReadLine());
								}
								if (battle == 1)
								{
									Console.WriteLine("Бьёт " + name.ToString());
									if (difficulty == 1)
									{
										playerHit = playerHit1.Next();
										playerHit = playerHit % (18 - 10) + 10;
									}
									else if (difficulty == 2)
									{
										playerHit = playerHit1.Next();
										playerHit = playerHit % (15 - 7) + 7;
									}
									else
									{
										playerHit = playerHit1.Next();
										playerHit = playerHit % (16 - 0) + 0;
									}
									Console.WriteLine("Он бьёт рукой!!\nМинус {0} ХП!!\n", playerHit);
									BillHP = BillHP - playerHit;
								}
								if (battle == 2)
								{
									if (difficulty == 1)
									{
										playerKritHit = playerKritHit1.Next();
										playerKritHit = playerKritHit % (25 - 8) + 8;
									}
									else if (difficulty == 2)
									{
										playerKritHit = playerKritHit1.Next();
										playerKritHit = playerKritHit % (20 - 9) + 9;
									}
									else
									{
										playerKritHit = playerKritHit1.Next();
										playerKritHit = playerKritHit % (23 - 0) + 0;
									}
									Console.WriteLine("Ого, потрясающий удар, " + name.ToString());
									Console.WriteLine("Минус {0} ХП!!!\n", playerKritHit);
									BillHP = BillHP - playerKritHit;
								}
								if (difficulty == 1)
								{
									BillHit = BillHit1.Next();
									BillHit = BillHit % (14 - 0) + 0;
								}
								else if (difficulty == 2)
								{
									BillHit = BillHit1.Next();
									BillHit = BillHit % (18 - 5) + 5;
								}
								else
								{
									BillHit = BillHit1.Next();
									BillHit = BillHit % (19 - 0) + 0;
								}
								Console.WriteLine("А сейчас настал черёд атаковать врагу!!!\nБедный игрок!");
								Console.WriteLine("Минус {0} ХП!!!\n", BillHit);
								playerHP = playerHP - BillHit;
								Console.WriteLine("Кол - во ХП у каждого из игроков на данный момент:\n{0} ХП - " + name.ToString(), playerHP);
								Console.WriteLine("{0} ХП - Билл\n", BillHP);
								if (BillHP == 0 || BillHP < 0)
								{
									Console.Clear();
									Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^\nПоздравляю, " + name.ToString());
									Console.WriteLine("Это твоя ПОБЕДА!!!!!\n-------------------------------------------------------------------------------------------\n\n\n\nНажмите 'Пробел', чтобы закончить бой\n");
									gamesAll++;
									gamesWin++;
									battlePercents = (gamesWin * 100) / gamesAll;
									Console.ReadKey();
								}
								else if (playerHP == 0 || playerHP < 0)
								{
									Console.Clear();
									Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^\nОу, " + name.ToString());
									Console.WriteLine("Это совсем не круто!!! Это твоё ПОРАЖЕНИЕ!!!!!\n-------------------------------------------------------------------------------------------\n\n\n\nНажмите 'Пробел', чтобы закончить бой\n");
									gamesAll++;
									battlePercents = (gamesWin * 100) / gamesAll;
									Console.ReadKey();
								}
							}
							break;
						}			
					case 2:
						{
							do
							{
								if(kolvoRound==1)
                                {
									Console.Clear();
									Console.WriteLine("Добро пожаловать в новый режим - Дуэль!\nВ Дуэли есть как некоторые схожести с обычной битвой, так и многие различия;\n\nВо-первых, Дуэль состоит из двух раундов (трёх, если по сумме счёт обоих бойцов после второго раунда будет одинаковым).\n\nПеред началом боя вам будут доступны (в рамках данной альфы) 2 предмета - Нож и Револьвер.\n\nВы сможете выбрать и взять из них только один и до конца Дуэли вы свой предмет поменять не сможете;\n\n.Оставшийся предмет возьмёт ваш противник - новый боец в игре - Джо!;\n\nИспользование данных предметов ограничено. В каждом раунде вы сможете использовать револьвер один раз, а нож дважды.\n\nОднако, есть вероятность, что вы промахнётесь, пытаясь поразить свою цель. Данный 'шанс' нескольким больше у Ножа.\n\nКонечно, помимо предметов (в рамках данной альфы) у вас есть и собственные удары - рукой и ногой. Про них также не следует забывать!;\n\nОб остальных тонкостях данного режима узнаете непосредственно в нём самом!;\n\n\nУдачи!\n\n\n\nНажмите любую кнопку, чтобы продолжить");
									Console.ReadKey();
									Console.Clear();
									Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t+++РЕЖИМ ИГРЫ - ДУЭЛЬ+++\n\t\t\t\t\t\t\t\t\t\t\t++++++++++++++++++++++++\n\t\t\t\t\t\t\t\t\t\t\t+++   Раунд 1   +++");
									Console.WriteLine("Мы приветствуем столь отважных двух бойцов, решившихся на поединок, а именно:\nДжо и " + name.ToString());
									Console.ReadKey();
									Console.Clear();
								}
								else if(kolvoRound==2||kolvoRound==3)
                                {
									if(kolvoRound==2)
                                    {
										Console.Clear();
										Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t+++РЕЖИМ ИГРЫ - ДУЭЛЬ+++\n\t\t\t\t\t\t\t\t\t\t\t++++++++++++++++++++++++\n\t\t\t\t\t\t\t\t\t\t\t+++   Раунд 2   +++");
										if(playerRound==1)
                                        {
											Console.WriteLine("Напоминаю, что в первом раунде победу одержал игрок " + name.ToString());
											Console.WriteLine("Джо следует побороться за право игры в 3 раунде!");
											Console.ReadKey();
											Console.Clear();
                                        }
                                        else
                                        {
											Console.WriteLine("В первом раунде Джо сумел победить своего оппонента. Посмотрим, сможет ли "+name.ToString());
											Console.WriteLine("Перевернуть исход дуэли! И, конечно, пожелаем бойцам удачи!");
											Console.ReadKey();
											Console.Clear();
                                        }
									}
                                    else
                                    {
										Console.Clear();
										Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t+++РЕЖИМ ИГРЫ - ДУЭЛЬ+++\n\t\t\t\t\t\t\t\t\t\t\t++++++++++++++++++++++++\n\t\t\t\t\t\t\t\t\t\t\t+++   Раунд 3   +++");
										Console.WriteLine("Бойцы приблизительно равны, но в дуэли только один победитель!\nИ совсем скоро мы его узнаем!");
										Console.ReadKey();
										Console.Clear();
									}
									
								}
								Console.WriteLine("Все готовы начинать, включая наших бойцов, которые сейчас выберут себе предметы!");
								Console.WriteLine("-----------------------------------------------\nВыберите себе предмет\n1 - Нож;\n2 - Револьвер\n-----------------------------------------------");
								duelChoise = int.Parse(Console.ReadLine());
								while (duelChoise < 1 || duelChoise > 2)
								{
									Console.Clear();
									Console.WriteLine("Ошибка ввода!\nПожалуйста, повторите!");
									Console.ReadKey();
									Console.WriteLine("-----------------------------------------------\nВыберите себе предмет\n1 - Нож;\n2 - Револьвер\n-----------------------------------------------");
									duelChoise = int.Parse(Console.ReadLine());
								}
								if (duelChoise == 1)
								{
									Console.Clear();
									Console.WriteLine("Джо выбирает револьвер, а хладнокровным оружием довольствуется " + name.ToString());
									Console.ReadKey();
									Console.WriteLine("А сейчас начинается самое интересное!! Начнёт поединок " + name.ToString());
									Console.ReadKey();
								}
								else if (duelChoise == 2)
								{
									Console.Clear();
									Console.WriteLine("Джо решил выбрать нож, револьвер достаётся игроку с именем " + name.ToString());
									Console.ReadKey();
									Console.WriteLine("А сейчас начнётся самое интересное!! Начнёт поединок " + name.ToString());
									Console.ReadKey();
								}
								switch (duelChoise)
								{
									case 1:
										{
											JoeHP = 100;
											playerHP = 100;
											playerKnife = 1;
											enemyKnife = 0;
											playerRev = 0;
											enemyRev = 1;
											kolvoRev = 1;
											kolvoKnife = 2;
											do
											{
												Console.Clear();
												Console.WriteLine("Наш первый боец медленно подходит к Джо. Непонятно, куда он целится и попадёт ли?");
												Console.ReadKey();
												Console.WriteLine("-----------------------------------------------\nКаким образом вы нападёте на своего оппонента?\n1 - Удар рукой;\n2 - Удар ногой;\n3 - Нож (осталось попыток - {0});\n-----------------------------------------------", kolvoKnife);
												hurtChoise = int.Parse(Console.ReadLine());
												while (hurtChoise < 1 || hurtChoise > 3)
												{
													Console.Clear();
													Console.WriteLine("Ошибка ввода!\nПожалуйста, повторите!");
													Console.ReadKey();
													Console.WriteLine("-----------------------------------------------\nКаким образом вы нападёте на своего оппонента?\n1 - Удар рукой;\n2 - Удар ногой;\n3 - Нож (осталось попыток - {0});\n-----------------------------------------------", kolvoKnife);
													hurtChoise = int.Parse(Console.ReadLine());
												}
												switch (hurtChoise)
												{
													case 1:
														{
															Console.Clear();
															playerHit = playerHit1.Next();
															playerHit = playerHit % (16 - 7) + 7;
															Console.WriteLine("И бойцу удалось обхитрить Джо! Джо теряет {0} единиц здоровья, которые нанёс ему " + name.ToString(), playerHit);
															Console.ReadKey();
															JoeHP = JoeHP - playerHit;
															break;
														}
													case 2:
														{
															Console.Clear();
															playerKritHit = playerKritHit1.Next();
															playerKritHit = playerKritHit % (22 - 5) + 5;
															Console.WriteLine("Следует удар ногой!! Этого Джо точно не мог ожидать. Джо теряет {0} единиц здоровья", playerKritHit);
															Console.ReadKey();
															JoeHP = JoeHP - playerKritHit;
															break;
														}
													case 3:
														{
															if (kolvoKnife == 0)
															{
																Console.Clear();
																Console.WriteLine("Вы уже использовали данный предмет указанное количество раз!");
																Console.ReadKey();
																Console.WriteLine("-----------------------------------------------\nКаким образом вы нападёте на своего оппонента?\n1 - Удар рукой;\n2 - Удар ногой;\n-----------------------------------------------");
																hurtChoise = int.Parse(Console.ReadLine());
																switch (hurtChoise)
																{
																	case 1:
																		{
																			Console.Clear();
																			playerHit = playerHit1.Next();
																			playerHit = playerHit % (16 - 7) + 7;
																			Console.WriteLine("И бойцу удалось обхитрить Джо! Джо теряет {0} единиц здоровья, которые нанёс ему " + name.ToString(), playerHit);
																			Console.ReadKey();
																			JoeHP = JoeHP - playerHit;
																			break;
																		}
																	case 2:
																		{
																			Console.Clear();
																			playerKritHit = playerKritHit1.Next();
																			playerKritHit = playerKritHit % (22 - 5) + 5;
																			Console.WriteLine("Следует удар ногой!! Этого Джо точно не мог ожидать. Джо теряет {0} единиц здоровья", playerKritHit);
																			Console.ReadKey();
																			JoeHP = JoeHP - playerKritHit;
																			break;
																		}
																}

															}
															else
															{
																knife = knife1.Next();
																knife = knife % (27 - 0) + 0;
																if (knife == 0)
																{
																	Console.Clear();
																	Console.WriteLine("Мастерски замахнулся, но Джо......увернулся!");
																	Console.ReadKey();
																}
																else
																{
																	Console.Clear();
																	Console.WriteLine("Должно быть, это довольно больно. Удар ножом прямо в цель! Джо теряет {0} единиц здоровья", knife);
																	Console.ReadKey();
																	JoeHP = JoeHP - knife;
																}
																kolvoKnife--;
															}
															break;
														}
												}
												Console.Clear();
												Console.WriteLine("Ну а теперь черёд атаковать Джо! Он с револьвером в руке медленно подходит к первому бойцу. Что же он предпринет теперь?");
												Console.ReadKey();
												rndJoeRev = rnd1JoeRev.Next();
												JoeHit = JoeHit1.Next();
												if (JoeHit > rndJoeRev)
												{
													Console.Clear();
													JoeHit = JoeHit1.Next();
													JoeHit = JoeHit % (18 - 6) + 6;
													Console.WriteLine("На этот раз Джо решил помахать кулаками. Удар у него солидный. Эх, " + name.ToString());
													Console.WriteLine("Не хотел бы оказаться на твоём месте, ты теряешь {0} единиц здоровья", JoeHit);
													Console.ReadKey();
													playerHP = playerHP - JoeHit;
												}
												else
												{
													if (kolvoRev == 1)
													{
														rndJoeRev = rnd1JoeRev.Next();
														rndJoeRev = rndJoeRev % (35 - 0) + 0;
														if (rndJoeRev == 0)
														{
															Console.Clear();
															Console.WriteLine("Джо решил выстрелить в своего оппонента!!");
															Console.ReadKey();
															Console.WriteLine("Увы!.....Неудачная попытка!\nДжо промахивается!");
															Console.ReadKey();
														}
														else
														{
															Console.Clear();
															Console.WriteLine("Джо решает стрелять!");
															Console.ReadKey();
															Console.WriteLine("Он попадает в бойца " + name.ToString());
															Console.WriteLine("Урон составил {0} единиц", rndJoeRev);
															Console.ReadKey();
															playerHP = playerHP - rndJoeRev;
															kolvoRev--;
														}
													}
													else
													{
														Console.Clear();
														JoeHit = JoeHit1.Next();
														JoeHit = JoeHit % (18 - 6) + 6;
														Console.WriteLine("На этот раз Джо решил помахать кулаками. Удар у него солидный. Эх, " + name.ToString());
														Console.WriteLine("Не хотел бы оказаться на твоём месте, ты теряешь {0} единиц здоровья", JoeHit);
														Console.ReadKey();
														playerHP = playerHP - JoeHit;
													}
												}
												if (playerHP <= 0)
												{
													Console.Clear();
													Console.WriteLine("Поздравляем............ДЖО!!!\nЭтот раунд ты выиграл!");
													Console.ReadKey();
													kolvoRound++;
													JoeRound++;
												}
												else if(JoeHP<=0)
												{
													Console.Clear();
													Console.WriteLine("Мы поздравляем победителя!\nВ этом раунде победителем становится " + name.ToString());
													Console.ReadKey();
													kolvoRound++;
													playerRound++;
												}
												else
                                                {
													Console.Clear();
													Console.WriteLine("Держу вас в курсе событий, дорогие друзья!\nНа данный момент здоровье бойцов:\n{0} единиц - Джо;\n{1} единиц - " + name.ToString(), JoeHP,playerHP);
													Console.ReadKey();
                                                }
											} while (playerHP > 0 && JoeHP > 0);
											break;

										}
									case 2:
										{
											
												JoeHP = 100;
												playerHP = 100;
												playerKnife = 0;
												enemyKnife = 1;
												playerRev = 1;
												enemyRev = 0;
												kolvoRev = 1;
												kolvoKnife = 2;
												do
												{
													Console.Clear();
													Console.WriteLine("Наш первый боец медленно подходит к Джо. Непонятно, куда он целится и попадёт ли?");
													Console.ReadKey();
													Console.WriteLine("-----------------------------------------------\nКаким образом вы нападёте на своего оппонента?\n1 - Удар рукой;\n2 - Удар ногой;\n3 - Револьвер (осталось попыток - {0});\n-----------------------------------------------", kolvoRev);
													hurtChoise = int.Parse(Console.ReadLine());
													while (hurtChoise < 1 || hurtChoise > 3)
													{
														Console.Clear();
														Console.WriteLine("Ошибка ввода!\nПожалуйста, повторите!");
														Console.ReadKey();
														Console.WriteLine("-----------------------------------------------\nКаким образом вы нападёте на своего оппонента?\n1 - Удар рукой;\n2 - Удар ногой;\n3 - Револьвер (осталось попыток - {0});\n-----------------------------------------------", kolvoRev);
														hurtChoise = int.Parse(Console.ReadLine());
													}
													switch (hurtChoise)
													{
														case 1:
															{
																Console.Clear();
																playerHit = playerHit1.Next();
																playerHit = playerHit % (16 - 7) + 7;
																Console.WriteLine("И бойцу удалось обхитрить Джо! Джо теряет {0} единиц здоровья, которые нанёс ему " + name.ToString(), playerHit);
																Console.ReadKey();
																JoeHP = JoeHP - playerHit;
																break;
															}
														case 2:
															{
																Console.Clear();
																playerKritHit = playerKritHit1.Next();
																playerKritHit = playerKritHit % (22 - 5) + 5;
																Console.WriteLine("Следует удар ногой!! Этого Джо точно не мог ожидать. Джо теряет {0} единиц здоровья", playerKritHit);
																Console.ReadKey();
																JoeHP = JoeHP - playerKritHit;
																break;
															}
														case 3:
															{
																if (kolvoRev == 0)
																{
																	Console.Clear();
																	Console.WriteLine("Вы уже использовали данный предмет указанное количество раз!");
																	Console.ReadKey();
																	Console.WriteLine("-----------------------------------------------\nКаким образом вы нападёте на своего оппонента?\n1 - Удар рукой;\n2 - Удар ногой;\n-----------------------------------------------");
																	hurtChoise = int.Parse(Console.ReadLine());
																	switch (hurtChoise)
																	{
																		case 1:
																			{
																				Console.Clear();
																				playerHit = playerHit1.Next();
																				playerHit = playerHit % (16 - 7) + 7;
																				Console.WriteLine("И бойцу удалось обхитрить Джо! Джо теряет {0} единиц здоровья, которые нанёс ему " + name.ToString(), playerHit);
																				Console.ReadKey();
																				JoeHP = JoeHP - playerHit;
																				break;
																			}
																		case 2:
																			{
																				Console.Clear();
																				playerKritHit = playerKritHit1.Next();
																				playerKritHit = playerKritHit % (22 - 5) + 5;
																				Console.WriteLine("Следует удар ногой!! Этого Джо точно не мог ожидать. Джо теряет {0} единиц здоровья", playerKritHit);
																				Console.ReadKey();
																				JoeHP = JoeHP - playerKritHit;
																				break;
																			}
																	}

																}
																else
																{
																	rev = rev1.Next();
																	rev = rev % (27 - 0) + 0;
																	if (knife == 0)
																	{
																		Console.Clear();
																		Console.WriteLine("Выстрел!!!\n Но Джо......увернулся!");
																		Console.ReadKey();
																	}
																	else
																	{
																		Console.Clear();
																		Console.WriteLine("Ууух! Выстрел! Попал! Джо теряет {0} единиц здоровья", rev);
																		Console.ReadKey();
																		JoeHP = JoeHP - rev;
																	}
																	kolvoRev--;
																}
																break;
															}
													}
													Console.Clear();
													Console.WriteLine("Ну а теперь черёд атаковать Джо! Он держит перед собой нож, готовясь выполнять удар! Или нет? Что же всё-таки он предпринет?");
													Console.ReadKey();
													rndJoeKnife = rnd1JoeKnife.Next();
													JoeHit = JoeHit1.Next();
													if (JoeHit > rndJoeKnife)
													{
														Console.Clear();
														JoeHit = JoeHit1.Next();
														JoeHit = JoeHit % (18 - 6) + 6;
														Console.WriteLine("На этот раз Джо решил помахать кулаками. Удар у него солидный. Эх, " + name.ToString());
														Console.WriteLine("Не хотел бы оказаться на твоём месте, ты теряешь {0} единиц здоровья", JoeHit);
														Console.ReadKey();
														playerHP = playerHP - JoeHit;
													}
													else
													{
														if (kolvoKnife == 2||kolvoKnife==1)
														{
															rndJoeKnife = rnd1JoeKnife.Next();
															rndJoeKnife = rndJoeKnife % (35 - 0) + 0;
															if (rndJoeKnife == 0)
															{
																Console.Clear();
																Console.WriteLine("Джо резко перекидывает нож из руки в руку!!!");
																Console.ReadKey();
																Console.WriteLine("Увы!.....Неудачная попытка!\nДжо промахивается!");
																Console.ReadKey();
															}
															else
															{
																Console.Clear();
																Console.WriteLine("Джо резко перекидывает нож из руки в руку!!!");
																Console.ReadKey();
																Console.WriteLine("Следует удар ножом!!! Джо попадает им в бойца " + name.ToString());
																Console.WriteLine("Урон составил {0} единиц", rndJoeKnife);
																Console.ReadKey();
																playerHP = playerHP - rndJoeKnife;
																kolvoKnife--;
															}
														}
														else
														{
															Console.Clear();
															JoeHit = JoeHit1.Next();
															JoeHit = JoeHit % (18 - 6) + 6;
															Console.WriteLine("На этот раз Джо решил помахать кулаками. Удар у него солидный. Эх, " + name.ToString());
															Console.WriteLine("Не хотел бы оказаться на твоём месте, ты теряешь {0} единиц здоровья", JoeHit);
															Console.ReadKey();
															playerHP = playerHP - JoeHit;
														}
													}
													if (playerHP <= 0)
													{
														Console.Clear();
														Console.WriteLine("Поздравляем............ДЖО!!!\nЭтот раунд ты выиграл!");
														Console.ReadKey();
														kolvoRound++;
														JoeRound++;
													}
													else if (JoeHP <= 0)
													{
														Console.Clear();
														Console.WriteLine("Мы поздравляем победителя!\nВ этом раунде победителем становится " + name.ToString());
														Console.ReadKey();
														kolvoRound++;
														playerRound++;
													}
													else
													{
														Console.Clear();
														Console.WriteLine("Держу вас в курсе событий, дорогие друзья!\nНа данный момент здоровье бойцов:\n{0} единиц - Джо;\n{1} единиц - " + name.ToString(), JoeHP, playerHP);
														Console.ReadKey();
													}

												} while (playerHP > 0 && JoeHP > 0);

											break;
										}
								}

							} while (playerRound != 2 || JoeRound != 2);
							if(playerRound==2)
                            {
								Console.Clear();
								Console.WriteLine("-----------------------------------------------\n++++++++++++++++++++++++++++++++++++++++++++++\nПоздравляю, "+name.ToString());
								Console.WriteLine("Ты - превосходный боец и победитель дуэли с Джо!\n-----------------------------------------------\n++++++++++++++++++++++++++++++++++++++++++++++");
                            }
							else
                            {
								Console.Clear();
								Console.WriteLine("-----------------------------------------------\n++++++++++++++++++++++++++++++++++++++++++++++\nЭту дуэль выиграл Джо!!\nМы поздравляем победителя!!\n-----------------------------------------------\n++++++++++++++++++++++++++++++++++++++++++++++\n");
								Console.ReadKey();
                            }
							break;
						}
					case 3:
						{
							Console.Clear();
							Console.WriteLine("Привет, " + name.ToString());
							Console.WriteLine("Здесь расположены все особенности этой (третьей) альфы:\n\n1. Во-первых, внимательно прочтите дисклеймер, появляется после запуска игры!\n2. Новая вкладка - Статистика;\n3. Новая вкладка - список изменений в прошлых альфах (история игры);\n4. Новая вкладка - Список возможных изменения в следующих альфах;\n5. Доступен выбор фона;\n6.\n\n\n\nМатюшев Глеб Игоревич - разработчик Лиги Сражений : Древней тайны\n\n\n\nНажмите 'Пробел', чтобы продолжить\n");
							Console.ReadKey();
							break;
						}
					case 4:
						{
							Console.Clear();
							Console.WriteLine("(ТЫ)\nЗдоровье:\nУровень сложности:\nЛегко - 110;\nСредне - 100;\nТяжело - 100;\nУдар (обычный):\nУровень сложности:\nЛегко - от 8 до 18;\nСредне - от 10 до 15;\nТяжело - от 8 до 15;\nСупер Удар:\nУровень сложности:\nЛегко - от 12 до 25;\nСредне - от 8 до 22;\nТяжело - от 8 до 22;\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++\nБилл\n(ВРАГ)\nЗдоровье:\nУровень сложности:\nЛегко - 100;\nСредне - 100;\nТяжело - 110;\nУдар (обычный):\nУровень сложности:\nЛегко - от 11 до 16;\nСредне - от 10 до 18;\nТяжело - от 10 до 17\n\n\n\nНажмите 'Пробел', чтобы продолжить\n");
							Console.ReadKey();
							break;
						}
					case 5:
						{
							Console.Clear();
							if(gamesAll==0&&gamesWin==0)
                            {
								Console.WriteLine("На данный момент ты не провёл никаких боёв");
								Console.ReadKey();
								break;
                            }
                            else
                            {
								battlePercents = (gamesWin * 100) / gamesAll;
								Console.WriteLine("Статистика:\nКоличество проведённых тобой боёв - {0}\nКоличество побед в боях - {1}\nПроцент всех побед в сравнении со всеми, проведёнными тобой боями - {2}%\n\n\n\nНажмите 'Пробел', чтобы продолжить\n", gamesAll, gamesWin, battlePercents);
								Console.ReadKey();
								break;
							}

						}
					case 6:
						{
							Console.Clear();
							Console.WriteLine("История изменений игры:\n\nAlpha 1:\n1. Была создана эта игра!\n2. На данный момент ты можешь сражаться только с одним ботом;\n\nAlpha 2:\n1. В игре доступен русский язык;\n2. В игре доступны ещё два вида сложности;\n3. Теперь у тебя и у твоего врага в игре есть имя;\n\nAlpha 3:\n1. Во-первых, внимательно прочтите дисклеймер, появляется после запуска игры!\n2. Новая вкладка - Статистика;\n3. Новая вкладка - список изменений в прошлых альфах (история игры);\n4. Новая вкладка - Список возможных изменений в следующих альфах;\n5. Доступен выбор фона;\n\n\n\nДля продолжения нажмите любую кнопку");
							Console.ReadKey();
							break;
                        }
                    case 7:
                        {
							Console.Clear();
							Console.WriteLine("Список возможных изменений в следующих альфах:\n\nAlpha 4:\n1. Продвинутая система повреждений бойцов;\n2. Новая система лечения бойцов;\n3. Продвинутая система ударов бойцов;\n4. Новые предметы в Дуэли;\n\n\n\nДля продолжения нажмите любую кнопку");
							Console.ReadKey();
							break;
                        }
                }
            } while (battleChoise != 0);
			
		}
    }
}
