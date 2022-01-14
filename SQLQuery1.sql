BEGIN 
IF NOT EXISTS (SELECT * FROM dbo.Clients
 WHERE [First Name] = 'Stoyan'
AND [Last Name] = 'Yavorov'
AND [GSM] = '0897777774'
AND [Email] = 'i_y@gmail.com')
BEGIN
INSERT INTO dbo.Clients ([First Name], [Last Name], [GSM], [Email], [Is Mature])
VALUES ('Stoyan', 'Yavorov', '0897777774', 'i_y@gmail.com', 'true')
END
END
