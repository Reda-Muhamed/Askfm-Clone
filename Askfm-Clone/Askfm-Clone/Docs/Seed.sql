-- === Insert Users ===
INSERT INTO Users (Name, Email, PasswordHash, AllowAnonymous, Coins)
VALUES 
('Alice', 'alice@test.com', '$2a$11$dxnBHGVQL1IGXrQTe.oHUugshxG19nw/4qLg/1zpLTVJHl3nPAvz.', 1, 100), -- john_456
('Bob', 'bob@test.com', '$2a$11$dxnBHGVQL1IGXrQTe.oHUugshxG19nw/4qLg/1zpLTVJHl3nPAvz.', 0, 50), -- john_456
('Charlie', 'charlie@test.com', '$2a$11$dxnBHGVQL1IGXrQTe.oHUugshxG19nw/4qLg/1zpLTVJHl3nPAvz.', 1, 200); -- john_456

-- === Insert Questions ===
INSERT INTO Questions (FromUserId, ToUserId, Content, CreatedAt, IsAnonymous, IsBlocked)
VALUES
(2, 1, 'What’s your favorite book?', GETUTCDATE(), 0, 0), -- Bob -> Alice
(1, 2, 'What’s your dream job?', GETUTCDATE(), 1, 0);    -- Alice -> Bob

-- === Insert Answers ===
INSERT INTO Answers (QuestionId, CreatorId, Content, CreatedAt)
VALUES
(1, 1, 'I love reading science fiction.', GETUTCDATE()); -- Alice answers Bob’s question

-- === Insert Comments ===
INSERT INTO Comments (AnswerId, FromUserId, Content, CreatedAt, IsAnonymous)
VALUES
(1, 2, 'Nice choice!', GETUTCDATE(), 0); -- Bob comments on Alice’s answer

-- === Insert Follows ===
INSERT INTO Follows (FollowerId, FolloweeId, CreatedAt)
VALUES
(1, 2, GETUTCDATE()); -- Alice follows Bob

-- === Insert Blocks (example, Bob blocks Charlie) ===
INSERT INTO Blocks (BlockerId, BlockedId, IsAnonymous, CreatedAt)
VALUES
(2, 3, 0, GETUTCDATE());

-- === Insert Likes ===
INSERT INTO Likes (UserId, AnswerId, CreatedAt)
VALUES
(3, 1, GETUTCDATE()); -- Charlie likes Alice’s answer

-- === Insert CoinTransactions ===
INSERT INTO CoinsTransactions (RecieverId, Amount, Type, CreatedAt)
VALUES
(3, 50, 'Reward', GETUTCDATE()); -- Charlie receives 50 coins
