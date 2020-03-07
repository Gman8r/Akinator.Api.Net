using Akinator.Api.Net.Enumerations;
using Akinator.Api.Net.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Akinator.Api.Net.Tests
{
    [TestClass]
    public class ClientIntegrationTests
    {
        [TestMethod]
        public async Task SimpleWorkflowTest_Arabic_Person()
        {
            using (IAkinatorClient client = new AkinatorClient(Language.Arabic, ServerType.Person))
            {
                var question = await client.StartNewGame();
                while (true)
                {
                    var nextQuestion = await client.Answer(AnswerOptions.Yes);
                    if (!client.GuessIsDue(nextQuestion))
                    {
                        continue;
                    }

                    var guess = await client.GetGuess();
                    if (!guess.Any())
                    {
                        Assert.Fail("No guess was found");
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        [TestMethod]
        public async Task SimpleWorkflowTest_English_Animal()
        {
            using (IAkinatorClient client = new AkinatorClient(Language.English, ServerType.Animal))
            {
                var question = await client.StartNewGame();
                while (true)
                {
                    var nextQuestion = await client.Answer(AnswerOptions.Yes);
                    if (!client.GuessIsDue(nextQuestion))
                    {
                        continue;
                    }

                    var guess = await client.GetGuess();
                    if (!guess.Any())
                    {
                        Assert.Fail("No guess was found");
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        [TestMethod]
        public async Task SimpleWorkflowTest_English_Object()
        {
            using (IAkinatorClient client = new AkinatorClient(Language.English, ServerType.Animal))
            {
                var question = await client.StartNewGame();
                while (true)
                {
                    var nextQuestion = await client.Answer(AnswerOptions.Yes);
                    if (!client.GuessIsDue(nextQuestion))
                    {
                        continue;
                    }

                    var guess = await client.GetGuess();
                    if (!guess.Any())
                    {
                        Assert.Fail("No guess was found");
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        [TestMethod]
        public async Task SimpleWorkflowTest_English_Person()
        {
            using (IAkinatorClient client = new AkinatorClient(Language.English, ServerType.Person))
            {
                var question = await client.StartNewGame();
                while (true)
                {
                    var nextQuestion = await client.Answer(AnswerOptions.Yes);
                    if (!client.GuessIsDue(nextQuestion))
                    {
                        continue;
                    }

                    var guess = await client.GetGuess();
                    if (!guess.Any())
                    {
                        Assert.Fail("No guess was found");
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        
        [TestMethod]
        public async Task SimpleWorkflowTest_French_Animal()
        {
            using (IAkinatorClient client = new AkinatorClient(Language.French, ServerType.Animal))
            {
                var question = await client.StartNewGame();
                while (true)
                {
                    var nextQuestion = await client.Answer(AnswerOptions.Yes);
                    if (!client.GuessIsDue(nextQuestion))
                    {
                        continue;
                    }

                    var guess = await client.GetGuess();
                    if (!guess.Any())
                    {
                        Assert.Fail("No guess was found");
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        [TestMethod]
        public async Task SimpleWorkflowTest_French_Object()
        {
            using (IAkinatorClient client = new AkinatorClient(Language.French, ServerType.Animal))
            {
                var question = await client.StartNewGame();
                while (true)
                {
                    var nextQuestion = await client.Answer(AnswerOptions.Yes);
                    if (!client.GuessIsDue(nextQuestion))
                    {
                        continue;
                    }

                    var guess = await client.GetGuess();
                    if (!guess.Any())
                    {
                        Assert.Fail("No guess was found");
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        [TestMethod]
        public async Task SimpleWorkflowTest_French_Person()
        {
            using (IAkinatorClient client = new AkinatorClient(Language.French, ServerType.Person))
            {
                var question = await client.StartNewGame();
                while (true)
                {
                    var nextQuestion = await client.Answer(AnswerOptions.Yes);
                    if (!client.GuessIsDue(nextQuestion))
                    {
                        continue;
                    }

                    var guess = await client.GetGuess();
                    if (!guess.Any())
                    {
                        Assert.Fail("No guess was found");
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        [TestMethod]
        public async Task SimpleWorkflowTest_German_Person()
        {
            using (IAkinatorClient client = new AkinatorClient(Language.German, ServerType.Person))
            {
                var question = await client.StartNewGame();
                while (true)
                {
                    var nextQuestion = await client.Answer(AnswerOptions.Yes);
                    if (!client.GuessIsDue(nextQuestion))
                    {
                        continue;
                    }

                    var guess = await client.GetGuess();
                    if (!guess.Any())
                    {
                        Assert.Fail("No guess was found");
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        [TestMethod]
        public async Task SimpleWorkflowTest_Italian_Animal()
        {
            using (IAkinatorClient client = new AkinatorClient(Language.Italian, ServerType.Animal))
            {
                var question = await client.StartNewGame();
                while (true)
                {
                    var nextQuestion = await client.Answer(AnswerOptions.Yes);
                    if (!client.GuessIsDue(nextQuestion))
                    {
                        continue;
                    }

                    var guess = await client.GetGuess();
                    if (!guess.Any())
                    {
                        Assert.Fail("No guess was found");
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        [TestMethod]
        public async Task SimpleWorkflowTest_Italian_Person()
        {
            using (IAkinatorClient client = new AkinatorClient(Language.Italian, ServerType.Person))
            {
                var question = await client.StartNewGame();
                while (true)
                {
                    var nextQuestion = await client.Answer(AnswerOptions.Yes);
                    if (!client.GuessIsDue(nextQuestion))
                    {
                        continue;
                    }

                    var guess = await client.GetGuess();
                    if (!guess.Any())
                    {
                        Assert.Fail("No guess was found");
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        [TestMethod]
        public async Task SimpleWorkflowTest_Russian_Person()
        {
            using (IAkinatorClient client = new AkinatorClient(Language.Russian, ServerType.Person))
            {
                var question = await client.StartNewGame();
                while (true)
                {
                    var nextQuestion = await client.Answer(AnswerOptions.Yes);
                    if (!client.GuessIsDue(nextQuestion))
                    {
                        continue;
                    }

                    var guess = await client.GetGuess();
                    if (!guess.Any())
                    {
                        Assert.Fail("No guess was found");
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        [TestMethod]
        public async Task SimpleWorkflowTest_Spanish_Animal()
        {
            using (IAkinatorClient client = new AkinatorClient(Language.Spanish, ServerType.Animal))
            {
                var question = await client.StartNewGame();
                while (true)
                {
                    var nextQuestion = await client.Answer(AnswerOptions.Yes);
                    if (!client.GuessIsDue(nextQuestion))
                    {
                        continue;
                    }

                    var guess = await client.GetGuess();
                    if (!guess.Any())
                    {
                        Assert.Fail("No guess was found");
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        [TestMethod]
        public async Task SimpleWorkflowTest_Spanish_Person()
        {
            using (IAkinatorClient client = new AkinatorClient(Language.Spanish, ServerType.Person))
            {
                var question = await client.StartNewGame();
                while (true)
                {
                    var nextQuestion = await client.Answer(AnswerOptions.Yes);
                    if (!client.GuessIsDue(nextQuestion))
                    {
                        continue;
                    }

                    var guess = await client.GetGuess();
                    if (!guess.Any())
                    {
                        Assert.Fail("No guess was found");
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        [TestMethod]
        [ExpectedException(typeof(OperationCanceledException))]
        public async Task StartNewGameThrowsExceptionOnCancelled()
        {
            using (IAkinatorClient client = new AkinatorClient(Language.English, ServerType.Person))
            {
                var src = new CancellationTokenSource();
                var cancellationToken = src.Token;
                src.Cancel();

                await client.StartNewGame(cancellationToken);
            }

            Assert.Fail("No exception was thrown");
        }

        [TestMethod]
        [ExpectedException(typeof(OperationCanceledException))]
        public async Task AnswerThrowsExceptionOnCancelled()
        {
            using (IAkinatorClient client = new AkinatorClient(Language.English, ServerType.Person))
            {
                var src = new CancellationTokenSource();
                var cancellationToken = src.Token;
                src.Cancel();

                await client.Answer(AnswerOptions.Yes, cancellationToken);
            }

            Assert.Fail("No exception was thrown");
        }

        [TestMethod]
        [ExpectedException(typeof(OperationCanceledException))]
        public async Task UndoAnswerThrowsExceptionOnCancelled()
        {
            using (IAkinatorClient client = new AkinatorClient(Language.English, ServerType.Person))
            {
                var src = new CancellationTokenSource();
                var cancellationToken = src.Token;
                src.Cancel();

                await client.UndoAnswer(cancellationToken);
            }

            Assert.Fail("No exception was thrown");
        }


        [TestMethod]
        [ExpectedException(typeof(OperationCanceledException))]
        public async Task GetGuessThrowsExceptionOnCancelled()
        {
            using (IAkinatorClient client = new AkinatorClient(Language.English, ServerType.Person))
            {
                var src = new CancellationTokenSource();
                var cancellationToken = src.Token;
                src.Cancel();

                await client.GetGuess(cancellationToken);
            }

            Assert.Fail("No exception was thrown");
        }

        [TestMethod]
        [ExpectedException(typeof(OperationCanceledException))]
        public async Task GetHallOfFameThrowsExceptionOnCancelled()
        {
            using (IAkinatorClient client = new AkinatorClient(Language.English, ServerType.Person))
            {
                var src = new CancellationTokenSource();
                var cancellationToken = src.Token;
                src.Cancel();

                await client.GetHallOfFame(cancellationToken);
            }

            Assert.Fail("No exception was thrown");
        }


        [TestMethod]
        [ExpectedException(typeof(OperationCanceledException))]
        public async Task SearchCharacterThrowsExceptionOnCancelled()
        {
            using (IAkinatorClient client = new AkinatorClient(Language.English, ServerType.Person))
            {
                var src = new CancellationTokenSource();
                var cancellationToken = src.Token;
                src.Cancel();

                await client.SearchCharacter("Brat Pitt", cancellationToken);
            }

            Assert.Fail("No exception was thrown");
        }

        [TestMethod]
        public async Task ReuseSessionWorks()
        {
            AkinatorUserSession userSessionFromFirstClient;

            using (IAkinatorClient client = new AkinatorClient(Language.English, ServerType.Person))
            {
                var question = await client.StartNewGame();
                Assert.AreEqual(0, question.Step);

                question = await client.Answer(AnswerOptions.Yes);
                Assert.AreEqual(1, question.Step);

                userSessionFromFirstClient = client.GetUserSession();
            }

            using (IAkinatorClient newClient = new AkinatorClient(Language.English, ServerType.Person, userSessionFromFirstClient))
            {
                var question = await newClient.Answer(AnswerOptions.Yes);
                Assert.AreEqual(2, question.Step);
            }
        }


        [TestMethod]
        public async Task UndoWorksAsExpected()
        {
            using (IAkinatorClient client = new AkinatorClient(Language.English, ServerType.Person))
            {
                var questionStart = await client.StartNewGame();
                Assert.AreEqual(0, questionStart.Step);

                var question1 = await client.Answer(AnswerOptions.Yes);
                Assert.AreEqual(1, question1.Step);

                var question2 = await client.Answer(AnswerOptions.Yes);
                Assert.AreEqual(2, question2.Step);

                var questionPrevious = await client.UndoAnswer();
                Assert.AreEqual(1, questionPrevious.Step);
                Assert.AreEqual(question1.Text, questionPrevious.Text);
            }
        }


        [TestMethod]
        public async Task ChildModeDoesNotThrowAnyExceptions()
        {
            using (IAkinatorClient client = new AkinatorClient(Language.English, ServerType.Person, childMode: true))
            {
                var questionStart = await client.StartNewGame(); 
                var nextQuestion = await client.Answer(AnswerOptions.Yes);
                Assert.AreEqual(0, questionStart.Step);
                Assert.AreEqual(1, nextQuestion.Step);
            }
        }

        [TestMethod]
        public async Task CurrentQuestionReturnsCurrentQuestion()
        {
            using (IAkinatorClient client = new AkinatorClient(Language.English, ServerType.Person))
            {
                var questionStart = await client.StartNewGame();
                Assert.AreEqual(questionStart.Text, client.CurrentQuestion.Text);

                questionStart = await client.Answer(AnswerOptions.Yes);
                Assert.AreEqual(questionStart.Text, client.CurrentQuestion.Text);

                questionStart = await client.Answer(AnswerOptions.Yes);
                Assert.AreEqual(questionStart.Text, client.CurrentQuestion.Text);

                questionStart = await client.UndoAnswer();
                Assert.AreEqual(questionStart.Text, client.CurrentQuestion.Text);
            }
        }

        [TestMethod]
        public async Task SearchCharacter_ReturnsValidCharactersForASearchTerm()
        {
            using (IAkinatorClient client = new AkinatorClient(Language.English, ServerType.Person))
            {
                await client.StartNewGame();
                var chars = await client.SearchCharacter("Brat Pitt");
                Assert.IsTrue(chars.Any(p => p.Name.Contains("brat pitt", StringComparison.InvariantCultureIgnoreCase)));
            }
        }

        [TestMethod]
        public async Task HallOfFameGivesValidResponse()
        {
            using (IAkinatorClient client = new AkinatorClient(Language.German, ServerType.Person))
            {
                var result = await client.GetHallOfFame();
                Assert.IsNotNull(result);
                Assert.AreNotEqual(0, result.Length);
            }
        }
    }
}
