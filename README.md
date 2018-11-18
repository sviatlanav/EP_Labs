# EP_Labs
Задача 2. Обычной проблемой анализа текстов является определение частоты и расположения слов в
документе. Эта информация запоминается в конкордансе, где различные слова перечислены в
алфавитном порядке и каждое слово снабжено ссылками на строки текста, в которых это слово
встречается. Рассмотрим следующую цитату.
Peter Piper picked a peck of pickled peppers. A peck of pickled
peppers Peter Piper picked. If Peter Piper picked a peck of
pickled peppers, where is the peck that Peter Piper picked?
Слово &quot;&quot;piper&quot;&quot; встречается здесь 4 раза в строках 1, 2 и 3. Слово &quot;&quot;pickled&quot;&quot; встречается 3 раза в
строках 1 и 3. Результат обработки этого текста представляется списком слов в алфавитном порядке,
для каждого слова указывается частота его появления в тексте (количество вхождений) и список
номеров строк, в которых встречается это слово. Если слово встречается в строке более одного раза,
то номер этой строки указывается в списке только один раз:
